// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.CSharp.Multiplayer.Manager
{
    public class HostChangedEventArgs : EventArgs
    {

        public MultiplayerMember HostMember
        {
            get;
            private set;
        }

    }
}
