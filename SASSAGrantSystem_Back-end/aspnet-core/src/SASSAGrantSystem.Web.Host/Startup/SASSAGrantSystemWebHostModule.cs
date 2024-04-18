using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SASSAGrantSystem.Configuration;

namespace SASSAGrantSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(SASSAGrantSystemWebCoreModule))]
    public class SASSAGrantSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SASSAGrantSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SASSAGrantSystemWebHostModule).GetAssembly());
        }
    }
}
