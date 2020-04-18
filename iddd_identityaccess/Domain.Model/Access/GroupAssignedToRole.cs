﻿// Copyright 2012,2013 Vaughn Vernon
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace SaaSOvation.IdentityAccess.Domain.Model.Access
{
    using System;
    using SaaSOvation.Common.Domain.Model;
    using SaaSOvation.IdentityAccess.Domain.Model.Identity;

    public class GroupAssignedToRole : IDomainEvent
    {
        public GroupAssignedToRole(TenantId tenantId, string roleName, string groupName)
        {
            this.EventVersion = 1;
            this.GroupName = groupName;
            this.OccurredOn = DateTime.Now;
            this.RoleName = roleName;
            this.TenantId = tenantId;
        }

        public int EventVersion { get; set; }

        public string GroupName { get; private set; }

        public DateTime OccurredOn { get; set; }

        public string RoleName { get; private set; }

        public TenantId TenantId;
    }
}
