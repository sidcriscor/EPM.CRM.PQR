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
    ///The CrearQueja recording.
    /// </summary>
    [TestModule("fd79fbb9-e1f8-468d-82f6-e6d689cadda4", ModuleType.Recording, 1)]
    public partial class CrearQueja : ITestModule
    {
        /// <summary>
        /// Holds an instance of the EPM.CRM.PQR.EPM_CRM_PQRRepository repository.
        /// </summary>
        public static EPM.CRM.PQR.EPM_CRM_PQRRepository repo = EPM.CRM.PQR.EPM_CRM_PQRRepository.Instance;

        static CrearQueja instance = new CrearQueja();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CrearQueja()
        {
            pps = "CL 98 C CR 80 C -30";
            pFormPrueba = "xx";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CrearQueja Instance
        {
            get { return instance; }
        }

#region Variables

        string _pps;

        /// <summary>
        /// Gets or sets the value of variable pps.
        /// </summary>
        [TestVariable("76f25cdc-017e-49e0-aed3-567e9a199340")]
        public string pps
        {
            get { return _pps; }
            set { _pps = value; }
        }

        string _pFormPrueba;

        /// <summary>
        /// Gets or sets the value of variable pFormPrueba.
        /// </summary>
        [TestVariable("4b8f48bc-59a5-4851-a050-e8e018c5e93e")]
        public string pFormPrueba
        {
            get { return _pFormPrueba; }
            set { _pFormPrueba = value; }
        }

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
            Mouse.DefaultMoveTime = 400;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 600ms.", new RecordItemIndex(0));
            Delay.Duration(600, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CasosMisCasosActivosMedioVerbalM.SpanTagCasoNuevo' at Center.", repo.CasosMisCasosActivosMedioVerbalM.SpanTagCasoNuevoInfo, new RecordItemIndex(1));
            repo.CasosMisCasosActivosMedioVerbalM.SpanTagCasoNuevo.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(2));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CasosMisCasosActivosMedioVerbalM.SpanTagCasoNuevo' at Center.", repo.CasosMisCasosActivosMedioVerbalM.SpanTagCasoNuevoInfo, new RecordItemIndex(3));
            repo.CasosMisCasosActivosMedioVerbalM.SpanTagCasoNuevo.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 200ms.", new RecordItemIndex(4));
            Delay.Duration(200, false);
            
            //Formularios();
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
