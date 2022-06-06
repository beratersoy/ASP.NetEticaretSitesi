using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stajrapor.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Desriciption { get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string rolename, string description)
        {
            this.Desriciption = description;
        }
    }
}