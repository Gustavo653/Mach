using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mach.DTO;

namespace Mach.Infrastructure
{
    public interface ITokenService
    {
        Task<string> CreateToken(UserUpdateDto userUpdateDto);
    }
}