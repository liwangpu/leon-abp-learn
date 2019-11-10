using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyAbpLearn.Roles.Dto;
using MyAbpLearn.Users.Dto;

namespace MyAbpLearn.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
