using Mach.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach.Domain
{
    public class UserTeam : BaseEntity
    {
        public User User { get; set; }
        public Team Team { get; set; }
    }
}
