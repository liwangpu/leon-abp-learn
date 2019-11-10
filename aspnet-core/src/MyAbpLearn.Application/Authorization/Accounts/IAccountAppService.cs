using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpLearn.Authorization.Accounts.Dto;

namespace MyAbpLearn.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
