﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using AutomationSQLdm.Commons;
using AutomationSQLdm.Configuration;

namespace AutomationSQLdm.BVT.TC_722033
{
   
    [TestModule("49C52721-6CD0-4B74-8326-4B723A1E44C7", ModuleType.UserCode, 1)]
    public class VerifyquerydataconnectedwithuserandshowsdataonSummaryscreen :Base.BaseClass, ITestModule
    {
        
        public VerifyquerydataconnectedwithuserandshowsdataonSummaryscreen()
        {
            // Do not delete - a parameterless constructor is required!
        }
			 void ITestModule.Run()
        {
         	StartProcess();
        }
        
        bool StartProcess()
        {
        	try 
        	{
        		//Steps.RightClickOnServer(Config.ServerOptions_CMWIN2016S8);
        		//Steps.ClickProperties();
        	    //Steps.TestSQLAuthentication();
        		Steps.SelectRequiredServer(Config.ServerOptions_CMWIN2016S8);
        		Steps.ClickOnDataBasesTab();
        		Steps.ClickOnSummaryInDB();
        		Steps.VerifySummaryInDataBases();
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }
        
    }
}
