using Mach.DTO;

namespace Mach.Infrastructure
{
    public interface ITokenService
    {
        Task<string> CreateToken(UserUpdateDto userUpdateDto);
    }
}