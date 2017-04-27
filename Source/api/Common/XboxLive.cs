﻿// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Xbox.Services.CSharp
{
    using global::System;
    using global::System.IO;
    using Microsoft.Xbox.Services.CSharp.Social.Manager;
    using Microsoft.Xbox.Services.CSharp.Stats.Manager;
    using Microsoft.Xbox.Services.CSharp.Privacy;

    public partial class XboxLive : IDisposable
    {
        private bool disposed;
        private static XboxLive instance;
        private XboxLiveSettings settings;
        private IStatsManager statsManager;
        private ISocialManager socialManager;
        private PrivacyService privacyService;

        private static readonly object instanceLock = new object();
        private readonly XboxLiveAppConfiguration appConfig;

        private XboxLive()
        {
            this.settings = new XboxLiveSettings();

            try
            {
                this.appConfig = XboxLiveAppConfiguration.Instance;
            }
            catch (FileLoadException)
            {
                this.appConfig = null;
            }
        }

        public static XboxLive Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                        {
                            instance = new XboxLive();
                        }
                    }
                }
                return instance;
            }

            private set
            {
                instance = null;
            }
        }

        public ISocialManager SocialManager
        {
            get
            {
                if (Instance.socialManager == null)
                {
                    Instance.socialManager = Social.Manager.SocialManager.Instance;
                }
                return Instance.socialManager;
            }
        }

        public IStatsManager StatsManager
        {
            get
            {
                if (Instance.statsManager == null)
                {
                    Instance.statsManager = Stats.Manager.StatsManager.Instance;
                }
                return Instance.statsManager;
            }
        }

        public PrivacyService PrivacyService
        {
            get
            {
                if (Instance.privacyService == null)
                {
                    Instance.privacyService = new PrivacyService();
                }
                return Instance.privacyService;
            }
        }

        public XboxLiveSettings Settings
        {
            get { return Instance.settings; }
            set { Instance.settings = value; }
        }

        public XboxLiveAppConfiguration AppConfig
        {
            get { return Instance.appConfig; }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Instance = null;
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
