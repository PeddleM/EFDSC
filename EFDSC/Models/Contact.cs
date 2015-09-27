using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDSC.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Telephone { get;  set;}
        public string Telephone2 { get; set; }

        public Contact(string name, string role, string email, string telephone)
        {
            this.Name = name;
            this.Role = role;
            this.Email = email;
            this.Telephone = 
                telephone != "" ? telephone : "N/A";
        }
    }
}