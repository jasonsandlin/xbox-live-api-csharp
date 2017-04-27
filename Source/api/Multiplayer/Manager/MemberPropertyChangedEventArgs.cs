// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.CSharp.Multiplayer.Manager
{
    public class MemberPropertyChangedEventArgs : EventArgs
    {

        public string Properties
        {
            get;
            private set;
        }

        public MultiplayerMember Member
        {
            get;
            private set;
        }

    }
}
