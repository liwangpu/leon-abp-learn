using Abp.Authorization;
using MyAbpLearn.Authorization.Roles;
using MyAbpLearn.Authorization.Users;

namespace MyAbpLearn.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
