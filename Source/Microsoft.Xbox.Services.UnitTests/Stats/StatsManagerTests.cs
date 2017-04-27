﻿// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Xbox.Services.CSharp.UnitTests.Stats
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Xbox.Services.CSharp.Stats.Manager;

    [TestClass]
    public class StatsManagerTests : TestBase
    {
        [TestMethod]
        public void GetInstance()
        {
            IStatsManager sm = XboxLive.Instance.StatsManager;
            Assert.IsNotNull(sm);
        }
    }
}
