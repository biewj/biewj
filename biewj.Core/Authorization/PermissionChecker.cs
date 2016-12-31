using Abp.Authorization;
using biewj.Authorization.Roles;
using biewj.MultiTenancy;
using biewj.Users;

namespace biewj.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
