using Common.Infrastructure;
using Mach.Domain.Identity;

namespace Mach.Infrastructure
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> GetUserByUserNameAsync(string userName);
    }
}
