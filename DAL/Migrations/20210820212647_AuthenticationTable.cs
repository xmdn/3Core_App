using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AuthenticationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthLevelRefId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthLevelRegId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AuthenticationLevels",
                columns: table => new
                {
                    AuthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Authname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthenticationLevels", x => x.AuthId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_AuthLevelRegId",
                table: "User",
                column: "AuthLevelRegId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AuthenticationLevels_AuthLevelRegId",
                table: "User",
                column: "AuthLevelRegId",
                principalTable: "AuthenticationLevels",
                principalColumn: "AuthId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_AuthenticationLevels_AuthLevelRegId",
                table: "User");

            migrationBuilder.DropTable(
                name: "AuthenticationLevels");

            migrationBuilder.DropIndex(
                name: "IX_User_AuthLevelRegId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AuthLevelRefId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AuthLevelRegId",
                table: "User");
        }
    }
}
