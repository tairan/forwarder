using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Forwarder.Authorization;

namespace Forwarder
{
    [DependsOn(
        typeof(ForwarderCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ForwarderApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ForwarderAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ForwarderApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
