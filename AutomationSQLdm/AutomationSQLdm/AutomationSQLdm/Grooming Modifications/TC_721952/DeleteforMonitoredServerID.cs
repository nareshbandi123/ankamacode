
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

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using AutomationSQLdm.Configuration;
using AutomationSQLdm.DataBaseOperations;
using AutomationSQLdm.Commons;

namespace AutomationSQLdm.Grooming_Modifications.TC_721952
{
    
    [TestModule("A99B8D48-8CE4-4DC1-8071-6850FC9AB5C2", ModuleType.UserCode, 1)]
    public class DeleteforMonitoredServerID :Base.BaseClass, ITestModule
    {
        
        public DeleteforMonitoredServerID()
        {
            
        }
        
         void ITestModule.Run()
        {
         	StartProcess();
        }
        
        bool StartProcess()
        {
        	try 
        	{
        		
        		//Steps.OpenProperties(Config.ServerOptions_CMWIN2016S8);
        		Steps.DeleteSQLServerInstance(Config.ServerOptions_CMWIN2016S8);
        		
//        		//Verify MonitoredSQLServers Table Info in DB
//	            string queryMonitoredSQLServers = "Select * from MonitoredSQLServers";
//	        	DataTable dtMonitoredSQLServers = DataAccess.GetData(queryMonitoredSQLServers);
//	        	if(dtMonitoredSQLServers != null && dtMonitoredSQLServers.Rows.Count > 0)
//	        	{
//	      			Reports.ReportLog("No Of Servers Monitored Is : " + dtMonitoredSQLServers.Rows.Count, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
//	        	}
//	        	else
//	        	{
//	        		Reports.ReportLog("Servers are not available for Monitor", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
//	        		
//	        	}
//	        	
//	        	
//	
//	        	//Verify AnalysisConfiguration Table Info in DB
//	            string queryAnalysisConfiguration = "Select * from dbo.AnalysisConfiguration";
//	        	DataTable dtAnalysisConfiguration = DataAccess.GetData(queryAnalysisConfiguration);
//	        	if(dtAnalysisConfiguration != null && dtAnalysisConfiguration.Rows.Count > 0)
//	        	{
//	      			Reports.ReportLog("No Of Records in AnalysisConfiguration Before Delete Is : " + dtAnalysisConfiguration.Rows.Count, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
//	        	}
//	        	else
//	        	{
//	        		Reports.ReportLog("No Records in AnalysisConfiguration", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
//	        		
//	        	}
	        		
        	} 
        	catch (Exception)
        	{
        		//Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }

       
    }
}
