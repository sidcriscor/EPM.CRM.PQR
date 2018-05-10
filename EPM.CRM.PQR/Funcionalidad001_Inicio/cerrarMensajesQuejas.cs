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

namespace EPM.CRM.PQR.Funcionalidad001_Inicio
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The cerrarMensajesQuejas recording.
    /// </summary>
    [TestModule("c6c12efc-be67-4a41-8f4c-99cd8f48cd34", ModuleType.Recording, 1)]
    public partial class cerrarMensajesQuejas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the EPM.CRM.PQR.EPM_CRM_PQRRepository repository.
        /// </summary>
        public static EPM.CRM.PQR.EPM_CRM_PQRRepository repo = EPM.CRM.PQR.EPM_CRM_PQRRepository.Instance;

        static cerrarMensajesQuejas instance = new cerrarMensajesQuejas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public cerrarMensajesQuejas()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static cerrarMensajesQuejas Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MessageFromWebpage.ButtonOK' at 44;15.", repo.MessageFromWebpage.ButtonOKInfo, new RecordItemIndex(0));
            repo.MessageFromWebpage.ButtonOK.Click("44;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MessageFromWebpage.ButtonOK' at 45;15.", repo.MessageFromWebpage.ButtonOKInfo, new RecordItemIndex(1));
            repo.MessageFromWebpage.ButtonOK.Click("45;15");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}