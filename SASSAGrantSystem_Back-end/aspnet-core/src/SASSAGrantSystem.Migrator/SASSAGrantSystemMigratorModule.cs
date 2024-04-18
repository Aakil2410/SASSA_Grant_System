using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SASSAGrantSystem.Configuration;
using SASSAGrantSystem.EntityFrameworkCore;
using SASSAGrantSystem.Migrator.DependencyInjection;

namespace SASSAGrantSystem.Migrator
{
    [DependsOn(typeof(SASSAGrantSystemEntityFrameworkModule))]
    public class SASSAGrantSystemMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SASSAGrantSystemMigratorModule(SASSAGrantSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SASSAGrantSystemMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SASSAGrantSystemConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SASSAGrantSystemMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
