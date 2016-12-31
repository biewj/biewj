using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using biewj.Users.Dto;

namespace biewj.Users
{
    /// <summary>
    /// �û��ӿ�
    /// </summary>
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);
        /// <summary>
        /// �ӽ�ɫ���Ƴ�ָ���û�
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task RemoveFromRole(long userId, string roleName);

        /// <summary>
        /// ��ȡ�����û�
        /// </summary>
        /// <returns></returns>
        Task<ListResultDto<UserListDto>> GetUsers();

        /// <summary>
        /// �����û�
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateUser(CreateUserInput input);
    }
}