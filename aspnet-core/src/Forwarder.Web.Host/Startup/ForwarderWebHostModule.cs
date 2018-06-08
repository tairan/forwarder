using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Forwarder.Configuration;

namespace Forwarder.Web.Host.Startup
{
    [DependsOn(
       typeof(ForwarderWebCoreModule))]
    public class ForwarderWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ForwarderWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ForwarderWebHostModule).GetAssembly());
        }
    }
}
