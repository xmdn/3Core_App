using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3Core_App.Models
{
    public class UserViewModel
    {
        public Int64 UserId { get; set; }
     
        public String Username { get; set; }
       
        public String EmailAddress { get; set; }

        public Int32 AuthLevel { get; set; }
    }
}
