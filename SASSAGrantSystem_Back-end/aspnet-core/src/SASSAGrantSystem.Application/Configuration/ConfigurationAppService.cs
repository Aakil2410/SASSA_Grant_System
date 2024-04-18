using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SASSAGrantSystem.Configuration.Dto;

namespace SASSAGrantSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SASSAGrantSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
