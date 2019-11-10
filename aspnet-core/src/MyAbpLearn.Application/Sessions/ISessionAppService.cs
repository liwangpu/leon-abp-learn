using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpLearn.Sessions.Dto;

namespace MyAbpLearn.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
