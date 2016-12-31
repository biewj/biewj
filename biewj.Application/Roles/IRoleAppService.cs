using System.Threading.Tasks;
using Abp.Application.Services;
using biewj.Roles.Dto;

namespace biewj.Roles
{
    /// <summary>
    /// 应用角色
    /// </summary>
    public interface IRoleAppService : IApplicationService
    {
        /// <summary>
        /// 更新应用角色
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
