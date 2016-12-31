using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using biewj.Users.Dto;

namespace biewj.Users
{
    /// <summary>
    /// 用户接口
    /// </summary>
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);
        /// <summary>
        /// 从角色中移除指定用户
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task RemoveFromRole(long userId, string roleName);

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        Task<ListResultDto<UserListDto>> GetUsers();

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateUser(CreateUserInput input);
    }
}