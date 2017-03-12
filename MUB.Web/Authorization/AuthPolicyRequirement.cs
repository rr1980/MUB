using Microsoft.AspNetCore.Authorization;
using MUB.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUB.Web.Authorization
{
    public class AuthPolicyRequirement : IAuthorizationRequirement
    {
        public UserRoleType UserRoleType;

        public AuthPolicyRequirement(UserRoleType type)
        {
            this.UserRoleType = type;
        }
    }
}
