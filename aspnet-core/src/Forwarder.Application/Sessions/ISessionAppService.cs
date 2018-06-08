using System.Threading.Tasks;
using Abp.Application.Services;
using Forwarder.Sessions.Dto;

namespace Forwarder.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
