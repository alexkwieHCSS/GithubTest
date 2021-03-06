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

namespace AutoInstall
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MakeNewEstimate recording.
    /// </summary>
    [TestModule("75773a13-e9eb-4ccd-9dd6-24a451b5566d", ModuleType.Recording, 1)]
    public partial class MakeNewEstimate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static MakeNewEstimate instance = new MakeNewEstimate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MakeNewEstimate()
        {
            EstimateCode = "EST-1";
            EstimateName = "Estimate 1";
            EstimateDescription = "THIS IS A TEST ESTIMATE";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MakeNewEstimate Instance
        {
            get { return instance; }
        }

#region Variables

        string _EstimateCode;

        /// <summary>
        /// Gets or sets the value of variable EstimateCode.
        /// </summary>
        [TestVariable("2379eb6a-b09c-4f9f-8235-a98a3e83567d")]
        public string EstimateCode
        {
            get { return _EstimateCode; }
            set { _EstimateCode = value; }
        }

        string _EstimateName;

        /// <summary>
        /// Gets or sets the value of variable EstimateName.
        /// </summary>
        [TestVariable("4b298db4-75dd-49df-aadf-b0e5c971d98c")]
        public string EstimateName
        {
            get { return _EstimateName; }
            set { _EstimateName = value; }
        }

        string _EstimateDescription;

        /// <summary>
        /// Gets or sets the value of variable EstimateDescription.
        /// </summary>
        [TestVariable("723da44e-0327-4cbf-bfbd-d70a3eba0cf2")]
        public string EstimateDescription
        {
            get { return _EstimateDescription; }
            set { _EstimateDescription = value; }
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.FileTab' at Center.", repo.HeavyBidApp.Tabs.FileTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.FileTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.File.NewEstimateButton' at Center.", repo.HeavyBidApp.Buttons.File.NewEstimateButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.File.NewEstimateButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBDropDownOptions.NewEstimate' at Center.", repo.HBDropDownOptions.NewEstimateInfo, new RecordItemIndex(2));
            repo.HBDropDownOptions.NewEstimate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateCodeTextBox' at Center.", repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateCodeTextBoxInfo, new RecordItemIndex(3));
            repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateCodeTextBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EstimateCode' with focus on 'HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateCodeTextBox'.", repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateCodeTextBoxInfo, new RecordItemIndex(4));
            repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateCodeTextBox.PressKeys(EstimateCode);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.NextButton' at Center.", repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.NextButtonInfo, new RecordItemIndex(5));
            repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateNameTextBox' at Center.", repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateNameTextBoxInfo, new RecordItemIndex(6));
            repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateNameTextBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EstimateName' with focus on 'HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateNameTextBox'.", repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateNameTextBoxInfo, new RecordItemIndex(7));
            repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateNameTextBox.PressKeys(EstimateName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateDescriptionTextBox' at Center.", repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateDescriptionTextBoxInfo, new RecordItemIndex(8));
            repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateDescriptionTextBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EstimateDescription' with focus on 'HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateDescriptionTextBox'.", repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateDescriptionTextBoxInfo, new RecordItemIndex(9));
            repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.EstimateDescriptionTextBox.PressKeys(EstimateDescription);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.NextButton' at Center.", repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.NextButtonInfo, new RecordItemIndex(10));
            repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.FinishButton' at Center.", repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.FinishButtonInfo, new RecordItemIndex(11));
            repo.HBPopUpScreens.FromFileButtons.NewEstimateRelated.NewEstimate.FinishButton.Click();
            Delay.Milliseconds(200);
            
            ValidateEstimateExists();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
