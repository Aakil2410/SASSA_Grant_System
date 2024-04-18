using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SASSAGrantSystem.Authorization;

namespace SASSAGrantSystem
{
    [DependsOn(
        typeof(SASSAGrantSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SASSAGrantSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SASSAGrantSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SASSAGrantSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
