using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mach.Domain.Enum;
using Microsoft.AspNetCore.Identity;

namespace Mach.Domain.Identity
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public virtual PersonType PersonType { get; set; }
        public virtual IEnumerable<UserTeam> UserTeams { get; set; }
        public virtual IEnumerable<UserRole> UserRoles { get; set; }
    }
}