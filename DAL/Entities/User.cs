using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class User
    {
        [Key]
        public Int64 Id { get; set; }

        [Required]
        public String Username { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }

        [Required]
        public Int32 AuthLevelRefId { get; set; }
    }
}
