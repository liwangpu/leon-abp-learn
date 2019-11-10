using System.Threading.Tasks;
using MyAbpLearn.Configuration.Dto;

namespace MyAbpLearn.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
