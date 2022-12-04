using Mach.Domain.Identity;

namespace Mach.Domain
{
    public class UserTeam : BaseEntity
    {
        public User User { get; set; }
        public Team Team { get; set; }
    }
}
