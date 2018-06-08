using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Forwarder.Configuration.Dto;

namespace Forwarder.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ForwarderAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
