using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SASSAGrantSystem.Controllers
{
    public abstract class SASSAGrantSystemControllerBase: AbpController
    {
        protected SASSAGrantSystemControllerBase()
        {
            LocalizationSourceName = SASSAGrantSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
