// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.CSharp.Achievements
{
    public class AchievementRequirement
    {

        public string TargetProgressValue
        {
            get;
            private set;
        }

        public string CurrentProgressValue
        {
            get;
            private set;
        }

        public string Id
        {
            get;
            private set;
        }

    }
}
