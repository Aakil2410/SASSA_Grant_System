using Abp.Authorization;
using SASSAGrantSystem.Authorization.Roles;
using SASSAGrantSystem.Authorization.Users;

namespace SASSAGrantSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
