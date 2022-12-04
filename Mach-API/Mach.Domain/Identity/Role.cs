using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Mach.Domain.Identity
{
    public class Role : IdentityRole<Guid>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}