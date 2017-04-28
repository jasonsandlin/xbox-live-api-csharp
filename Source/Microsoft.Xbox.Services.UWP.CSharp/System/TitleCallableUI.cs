// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Xbox.Services.CSharp.System
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Threading.Tasks;
    using Microsoft.Xbox.Services;

    public class TitleCallableUI
    {
        /// <summary>
        /// Shows UI displaying the profile card for a specified user.
        /// </summary>
        /// <param name="user">XboxLiveUser that identifies the user to show the UI on behalf of.</param>
        /// <param name="targetXboxUserId">The Xbox User ID to show information about.</param>
        /// <returns>
        /// An interface for tracking the progress of the asynchronous call.
        /// The operation completes when the UI is closed.
        /// </returns>
        public static Task ShowProfileCardUIAsync(XboxLiveUser user, string targetXboxUserId)
        {
            return Task.FromResult(true);

            //return Microsoft.Xbox.Services.System.TitleCallableUI.ShowProfileCardUIForUserAsync(
            //        targetXboxUserId,
            //        user.WindowsSystemUser
            //        ).AsTask();
        }

        /// <summary>
        /// Checks if the current user has a specific privilege
        /// </summary>
        /// <param name="user">XboxLiveUser that identifies the user to show the UI on behalf of.</param>
        /// <param name="privilege">The privilege to check.</param>
        /// <returns>
        /// A boolean which is true if the current user has the privilege.
        /// </returns>
        public static int CheckGamingPrivilegeSilently(XboxLiveUser user, GamingPrivilege privilege)
        {
            TestWindowsRuntimeComponent.Class1 c = new TestWindowsRuntimeComponent.Class1();
            return c.Add(10, 20);

            //return 0;
            //string scope;
            //string policy;
            //GetPrivilegeScopePolicy(out scope, out policy);

            //return Microsoft.Xbox.Services.System.TitleCallableUI.CheckGamingPrivilegeSilentlyForUser(
            //        (Microsoft.Xbox.Services.System.GamingPrivilege)privilege,
            //        user.WindowsSystemUser
            //        );
        }

        /// <summary>
        /// Checks if the current user has a specific privilege and if it doesn't, it shows UI 
        /// </summary>
        /// <param name="user">XboxLiveUser that identifies the user to show the UI on behalf of.</param>
        /// <param name="privilege">The privilege to check.</param>
        /// <param name="friendlyMessage">Text to display in addition to the stock text about the privilege</param>
        /// <returns>
        /// An interface for tracking the progress of the asynchronous call.
        /// The operation completes when the UI is closed.
        /// A boolean which is true if the current user has the privilege.
        /// </returns>
        public static Task<bool> CheckGamingPrivilegeWithUIAsync(XboxLiveUser user, GamingPrivilege privilege, string friendlyMessage)
        {
            return Task.FromResult(true);

            //return Microsoft.Xbox.Services.System.TitleCallableUI.CheckGamingPrivilegeWithUIForUser(
            //        (Microsoft.Xbox.Services.System.GamingPrivilege)privilege,
            //        friendlyMessage,
            //        user.WindowsSystemUser
            //        ).AsTask();
        }

        //private static void GetPrivilegeScopePolicy(out string scope, out string policy)
        //{
        //    var appConfig = XboxLiveAppConfiguration.SingletonInstance;
        //    var authConfig = new AuthConfig
        //    {
        //        Sandbox = appConfig.Sandbox,
        //        Envrionment = appConfig.Environment
        //    };

        //    scope = authConfig.RPSTicketService;
        //    policy = authConfig.RPSTicketPolicy;
        //}
    }
}
