using System.Threading.Tasks;
using SASSAGrantSystem.Configuration.Dto;

namespace SASSAGrantSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
