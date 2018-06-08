using System.Threading.Tasks;
using Forwarder.Configuration.Dto;

namespace Forwarder.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
