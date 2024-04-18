using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SASSAGrantSystem.EntityFrameworkCore;
using SASSAGrantSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SASSAGrantSystem.Web.Tests
{
    [DependsOn(
        typeof(SASSAGrantSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SASSAGrantSystemWebTestModule : AbpModule
    {
        public SASSAGrantSystemWebTestModule(SASSAGrantSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SASSAGrantSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SASSAGrantSystemWebMvcModule).Assembly);
        }
    }
}