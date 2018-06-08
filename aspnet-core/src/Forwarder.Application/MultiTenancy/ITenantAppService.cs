using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Forwarder.MultiTenancy.Dto;

namespace Forwarder.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
