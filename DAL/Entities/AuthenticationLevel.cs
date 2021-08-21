using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class AuthenticationLevel
    {
        [Key]
        public Int32 AuthId { get; set; }

        [Required]
        public String Authname { get; set; }
        [ForeignKey("AuthLevelRegId")]
        public ICollection<User> Users { get; set; }
    }
}
