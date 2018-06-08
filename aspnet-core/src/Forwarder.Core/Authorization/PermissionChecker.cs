using Abp.Authorization;
using Forwarder.Authorization.Roles;
using Forwarder.Authorization.Users;

namespace Forwarder.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
