﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TestRail
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The view_users recording.
    /// </summary>
    [TestModule("45b9615f-9def-40c2-9075-3977b1bc3a15", ModuleType.Recording, 1)]
    public partial class view_users : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestRailRepository repository.
        /// </summary>
        public static TestRailRepository repo = TestRailRepository.Instance;

        static view_users instance = new view_users();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public view_users()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static view_users Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Administration' at 49;11.", repo.LoginTestRail.AdministrationInfo, new RecordItemIndex(0));
            repo.LoginTestRail.Administration.Click("49;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.ViewUsersRoles' at 40;4.", repo.LoginTestRail.ViewUsersRolesInfo, new RecordItemIndex(1));
            repo.LoginTestRail.ViewUsersRoles.Click("40;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tUsers & Roles\t\t\t\t\t') on item 'LoginTestRail.DivTagAllPr'.", repo.LoginTestRail.DivTagAllPrInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.LoginTestRail.DivTagAllPrInfo, "InnerText", "\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tUsers & Roles\t\t\t\t\t");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginTestRail.Dashboard' at 55;16.", repo.LoginTestRail.DashboardInfo, new RecordItemIndex(3));
            repo.LoginTestRail.Dashboard.Click("55;16");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
