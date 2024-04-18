using System.Threading.Tasks;
using Abp.Application.Services;
using SASSAGrantSystem.Sessions.Dto;

namespace SASSAGrantSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
