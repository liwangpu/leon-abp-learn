using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyAbpLearn.Controllers
{
    public abstract class MyAbpLearnControllerBase: AbpController
    {
        protected MyAbpLearnControllerBase()
        {
            LocalizationSourceName = MyAbpLearnConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
