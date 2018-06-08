using System.Threading.Tasks;
using Abp.Application.Services;
using Forwarder.Authorization.Accounts.Dto;

namespace Forwarder.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
