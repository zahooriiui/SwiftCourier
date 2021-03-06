﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftCourier.Web.AuthorizationPolicies
{
    public class HasPermissionHandler : AuthorizationHandler<HasPermissionRequirement>
    {
        protected override void Handle(AuthorizationContext context, HasPermissionRequirement requirement)
        {
            context.Succeed(requirement);
        }
    }
}
