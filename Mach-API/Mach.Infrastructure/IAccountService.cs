using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mach.DTO;
using Microsoft.AspNetCore.Identity;

namespace Mach.Infrastructure
{
    public interface IAccountService
    {
        Task<bool> UserExists(string username);
        Task<UserUpdateDto> GetUserByUserNameAsync(string username);
        Task<SignInResult> CheckUserPasswordAsync(UserUpdateDto userUpdateDto, string password);
        Task<UserUpdateDto> CreateAccountAsync(UserDto userDto);
        Task<UserUpdateDto> UpdateAccount(UserUpdateDto userUpdateDto);
    }
}