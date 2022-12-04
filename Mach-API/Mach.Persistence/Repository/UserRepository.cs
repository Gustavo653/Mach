using Common.DataAccess;
using Mach.Domain.Identity;
using Mach.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mach.DataAccess.Repository
{
    public class UserRepository : BaseRepository<User, MachContext>, IUserRepository
    {
        public UserRepository(MachContext context) : base(context)
        {
        }
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await GetListAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await GetEntities().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await GetEntities().FirstOrDefaultAsync(x => x.UserName == userName);
        }
    }
}
