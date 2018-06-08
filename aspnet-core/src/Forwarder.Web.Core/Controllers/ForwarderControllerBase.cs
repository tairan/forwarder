using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Forwarder.Controllers
{
    public abstract class ForwarderControllerBase: AbpController
    {
        protected ForwarderControllerBase()
        {
            LocalizationSourceName = ForwarderConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
