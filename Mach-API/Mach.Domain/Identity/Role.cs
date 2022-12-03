using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Mach.Domain.Identity
{
    public class Role : IdentityRole<Guid>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}