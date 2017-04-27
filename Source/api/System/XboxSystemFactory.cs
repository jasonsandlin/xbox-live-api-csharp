// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xbox.Services.CSharp;
using Microsoft.Xbox.Services.CSharp.Shared;

namespace Microsoft.Xbox.Services.CSharp.System
{
    class XboxSystemFactory
    {
        private static XboxSystemFactory factory;
        public static XboxSystemFactory GetSingletonInstance()
        {
            if(factory == null)
            {
                factory = new XboxSystemFactory();
            }

            return factory;
        }

        private XboxSystemFactory()
        {
        }

        public IXboxWebsocketClient CreateWebsocketClient()
        {
#if WINDOWS_UWP
            return null;
#else
            return null;
#endif
        }
    }
}
