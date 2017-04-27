// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.CSharp.Multiplayer
{
    public enum MultiplayerSessionRestriction : int
    {
        Unknown = 0,
        None = 1,
        Local = 2,
        Followed = 3,
    }

}
