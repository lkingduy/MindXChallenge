using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindXChallenge.Data
{
    public class EntityUser : IdentityUser
    {
        public string School { get; set; }
    }
}
