// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.CSharp.Multiplayer.Manager
{
    public class FindMatchCompletedEventArgs : EventArgs
    {

        public Microsoft.Xbox.Services.CSharp.Multiplayer.MultiplayerMeasurementFailure InitializationFailureCause
        {
            get;
            private set;
        }

        public MatchStatus MatchStatus
        {
            get;
            private set;
        }

    }
}
