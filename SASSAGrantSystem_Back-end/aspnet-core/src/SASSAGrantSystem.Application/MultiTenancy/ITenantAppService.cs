using Abp.Application.Services;
using SASSAGrantSystem.MultiTenancy.Dto;

namespace SASSAGrantSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

