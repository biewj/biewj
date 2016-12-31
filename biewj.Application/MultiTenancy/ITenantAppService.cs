using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using biewj.MultiTenancy.Dto;

namespace biewj.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
