using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyAbpLearn.Configuration.Dto;

namespace MyAbpLearn.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyAbpLearnAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
