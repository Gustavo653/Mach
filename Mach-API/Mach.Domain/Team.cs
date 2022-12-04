﻿using System.Collections.Generic;

namespace Mach.Domain
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<UserTeam> UserTeams { get; set; }
    }
}
