using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Forwarder.Roles.Dto;
using Forwarder.Users.Dto;

namespace Forwarder.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
