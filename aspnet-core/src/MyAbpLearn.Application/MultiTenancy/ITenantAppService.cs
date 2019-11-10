using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyAbpLearn.MultiTenancy.Dto;

namespace MyAbpLearn.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

