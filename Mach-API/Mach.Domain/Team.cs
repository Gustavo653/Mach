using Mach.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach.Domain
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<UserTeam> UserTeams { get; set; }
    }
}
