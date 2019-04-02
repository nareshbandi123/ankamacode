using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using System.Data;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

using AutomationSQLdm.Commons;
using AutomationSQLdm.Extensions;
using AutomationSQLdm.Configuration;


namespace AutomationSQLdm.Grooming_Modifications
{
    public static class Steps 
    {
		public static GroomingRepo repo = GroomingRepo.Instance;
		public const string GROOMING_MENU = @"/contextmenu[@processname='SQLdmDesktopClient']/menuitem[@automationid='menuToolsGrooming']";
		
		
		public static void ClickOnTools()
		{
		try 
		{
		repo.Application.ToolsInfo.WaitForExists(new Duration(1000000));
		repo.Application.Tools.Click();
		Reports.ReportLog("ClickOnTools", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
		} 
		catch (Exception ex)
		{
		throw new Exception("Failed : ClickOnTools :" + ex.Message);
		}
		}
		
		public static void SelectGroomingOption()
		{ 
		try
		{
		Ranorex.MenuItem groomingMenuItem = GROOMING_MENU;
		if(groomingMenuItem != null) groomingMenuItem.ClickThis();
		Reports.ReportLog("SelectGroomingOption", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
		}
		catch (Exception ex)
		{
		throw new Exception("Failed : SelectGroomingOption :" + ex.Message);
		}
		}
		
		public static void VerifyAggregateforecastingValue()
		{
		try 
		{
		repo.GroomingOptionWindow.SelfInfo.WaitForExists(new Duration(1000000));
		if (repo.GroomingOptionWindow.AggregateTextboxInfo.Exists())
			Reports.ReportLog("Verify Aggregate forecasting data to daily records after is Displaying: " + repo.GroomingOptionWindow.AggregateTextbox.TextValue , Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
		else
			Reports.ReportLog("Verify Aggregate forecasting data to daily records after", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
		} 
		catch (Exception ex)
		{
		throw new Exception("Failed : VerifyAggregateforecastingValue :" + ex.Message);
		}
		}
		
		public static void VerifyGroomforecastingValue()
		{
		try 
		{
		repo.GroomingOptionWindow.SelfInfo.WaitForExists(new Duration(1000000));
		if (repo.GroomingOptionWindow.GroomForecastTextboxInfo.Exists())
			
			Reports.ReportLog("Groom forecasting data to daily records after is Displaying : " + repo.GroomingOptionWindow.GroomForecastTextbox.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
		else
			Reports.ReportLog("Groom forecasting data to daily records after", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
		} 
		catch (Exception ex)
		{
		throw new Exception("Failed : VerifyAggregateforecastingValue :" + ex.Message);
		}
		}
		
		public static void ClickOnCancel()
		{
		try 
			{	
				repo.GroomingOptionWindow.CancelButtonInfo.WaitForExists(new Duration(1000000));
				repo.GroomingOptionWindow.CancelButton.Click();
				Reports.ReportLog("Click On Cancel Button", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			} 
		catch (Exception ex)
			{
				throw new Exception("Failed : ClickOnCancel :" + ex.Message);
			}
		}
		
		public static void VerifyQueryIsRemovedFromText()
		{
		try 
		{
		
		//Verify Query is Removed from The Current time on the repository
		if (repo.GroomingOptionWindow.AggregationInCurrentTime.Caption.Contains("Query"))
			Reports.ReportLog("The Current time on the repository is Displaying Query Aggregation", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);	
		else
			Reports.ReportLog("The Current time on the repository is Displaying Only : " + repo.GroomingOptionWindow.AggregationInCurrentTime.Caption, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
		
		//Verify Query is Removed from The Current time on the repository
		repo.GroomingOptionWindow.SelfInfo.WaitForExists(new Duration(1000000));
		if (repo.GroomingOptionWindow.CombineOlderData.TextValue.Contains("Query"))
			Reports.ReportLog("Query is not Removed from The Current time on the repository", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);	
		else
			Reports.ReportLog("Combine older query data into daily roll-up records to save space is Displaying : " + repo.GroomingOptionWindow.CombineOlderData.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
		
		//Verify Query is Removed from What is the Current grooming status
		if (repo.GroomingOptionWindow.AggregationInCurrentGrooming.Caption.Contains("Query"))
			Reports.ReportLog("What is the Current grooming status is Displaying Query Aggregation", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);	
		else
			Reports.ReportLog("What is the Current grooming status is Displaying Only : " + repo.GroomingOptionWindow.AggregationInCurrentGrooming.Caption, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
		} 
		catch (Exception ex)
		{
		throw new Exception("Failed : VerifyQueryIsRemovedFromText :" + ex.Message);
		}
			
		}
		
		public static void VerifyGroomMetricsAndBaseLineFieldMaxValue()
		{
		try 
		{
		
		repo.GroomingOptionWindow.SelfInfo.WaitForExists(new Duration(1000000));
		repo.GroomingOptionWindow.GroomMetricsAndBaseLine.TextValue = "";
		repo.GroomingOptionWindow.GroomMetricsAndBaseLine.TextValue = "1100";
		if (repo.GroomingOptionWindow.GroomMetricsAndBaseLine.TextValue.Contains("1100"))					
			Reports.ReportLog("Groom standard metrics and baselines metrics is Displaying Max Value: " + repo.GroomingOptionWindow.GroomMetricsAndBaseLine.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
		else
			Reports.ReportLog("Groom standard metrics and baselines metrics is not showing Max Value", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
		} 
		catch (Exception ex)
		{
		throw new Exception("Failed : VerifyGroomMetricsAndBaseLineFieldMaxValue :" + ex.Message);
		}
		}
		
		public static void ClickOnServer(string serverName)
		{
			try 
			{
				repo.Application.AllServersInfo.WaitForItemExists(120000);
				TreeItem serveritem = repo.Application.AllServers.GetChildItem(serverName);
				if(serveritem != null) serveritem.ClickThis(); 
			} 
			catch (Exception ex) 
			{
				throw new Exception("Failed : ClickOnAllServers : " + ex.Message);
			}
		}
		
		public static void RightClickOnServer(string serverName)
		{
			try 
			{
				repo.Application.AllServersInfo.WaitForItemExists(120000);
				TreeItem serveritem = repo.Application.AllServers.GetChildItem(serverName);
				if(serveritem != null) serveritem.RightClick(); 
			} 
			catch (Exception ex) 
			{
				throw new Exception("Failed : ClickOnAllServers : " + ex.Message);
			}
		}
		
		public static void OpenProperties(string serverName)
		{
			try 
			{
				repo.Application.AllServersInfo.WaitForItemExists(120000);
				TreeItem serveritem = repo.Application.AllServers.GetChildItem(serverName);
				if(serveritem != null)
				{
					serveritem.RightClick();
					repo.SQLdmDC.PropertiesInfo.WaitForExists(120000);
					repo.SQLdmDC.Properties.ClickThis();
				}
			} 
			catch (Exception ex) 
			{
				throw new Exception("Failed : OpenProperties : " + ex.Message);
			}
		}
		
		public static void DeleteSQLServerInstance(string serverName)
		{
			try 
			{
				repo.Application.AllServersInfo.WaitForItemExists(120000);
				TreeItem serveritem = repo.Application.AllServers.GetChildItem(serverName);
				if(serveritem != null)
				{
					serveritem.RightClick();
					repo.SQLdmDC.DeleteInfo.WaitForExists(120000);
					repo.SQLdmDC.Delete.ClickThis();
				}
			} 
			catch (Exception ex) 
			{
				throw new Exception("Failed : OpenProperties : " + ex.Message);
			}
		}
		
		public static void EnterTextInAggregateForecasting(int AggregateForecasting)
		{
			try 
				{	
					repo.GroomingOptionWindow.AggregateTextboxInfo.WaitForExists(new Duration(1000000));
					//repo.GroomingOptionWindow.AggregateTextbox.TextValue = "";
					repo.GroomingOptionWindow.AggregateTextbox.TextValue = AggregateForecasting.ToString();
					
					
					Reports.ReportLog("Successfully Entered Aggregation Value: " + AggregateForecasting, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				} 
			catch (Exception ex)
				{
					throw new Exception("Failed : EnterTextInAggregateForecasting :" + ex.Message);
				}
		}
		
		public static void ClickOnGroomNow()
		{
			try 
				{	
					repo.GroomingOptionWindow.btnGroomNowInfo.WaitForExists(new Duration(1000000));
					repo.GroomingOptionWindow.btnGroomNow.ClickThis();
					Reports.ReportLog("Click On Groom Now Button", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				} 
			catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnGroomNow :" + ex.Message);
				}
		}
 		 
		public static void ClickOnAggregateNow()
		{
			try 
				{	
					repo.GroomingOptionWindow.btnAggregateNowInfo.WaitForExists(new Duration(1000000));
					repo.GroomingOptionWindow.btnAggregateNow.ClickThis();
					Reports.ReportLog("Click On Aggregate Now Button", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				} 
			catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnAggregateNow :" + ex.Message);
				}
		}
		
		public static void ClickOnRefresh()
		{
			try 
				{	
					repo.GroomingOptionWindow.btnRefreshInfo.WaitForExists(new Duration(1000000));
					repo.GroomingOptionWindow.btnRefresh.ClickThis();
					Reports.ReportLog("Click On Refresh Button", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				} 
			catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnRefresh :" + ex.Message);
				}
		}
		
				
		
		public static void ClickOnOk()
		{
			try 
				{	
					repo.GroomingOptionWindow.btnGOWOkInfo.WaitForExists(new Duration(1000000));
					repo.GroomingOptionWindow.btnGOWOk.ClickThis();
					Reports.ReportLog("Click On Ok Button", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				} 
			catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnOk :" + ex.Message);
				}
		}
		
		public static void VerifyCurrentRunningStatusInDataGrooming(string strCurrentRunningStatusInDG)
		{
			try 
				{	
					repo.GroomingOptionWindow.txtDGCurrentlyRunningStatusInfo.WaitForExists(new Duration(1000000));
					
					if (repo.GroomingOptionWindow.txtDGCurrentlyRunningStatus.TextValue == strCurrentRunningStatusInDG)
						Reports.ReportLog("Successfully Verified Current Running Status In DataGrooming As: " + repo.GroomingOptionWindow.txtDGCurrentlyRunningStatus.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Failed to Verify Current Running Status In DataGrooming As: " + strCurrentRunningStatusInDG, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
			catch (Exception ex)
				{
					throw new Exception("Failed : VerifyCurrentRunningStatusInDataGrooming :" + ex.Message);
				}
		}
		
		public static void VerifyCompletionStatusInDataGrooming(string strCompletionStatusInDG)
		{
			try 
				{	
					repo.GroomingOptionWindow.txtDGCompletionStatusInfo.WaitForExists(new Duration(1000000));
					
					if (repo.GroomingOptionWindow.txtDGCompletionStatus.TextValue == strCompletionStatusInDG)
						Reports.ReportLog("Successfully Verified Completion Status In DataGrooming As: " + repo.GroomingOptionWindow.txtDGCompletionStatus.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Failed to Verify Completion Status In DataGrooming As: " + strCompletionStatusInDG, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
			catch (Exception ex)
				{
					throw new Exception("Failed : VerifyCompletionStatusInDataGrooming :" + ex.Message);
				}
		}
		
		public static void VerifyCurrentRunningStatusInAggregation(string strCurrentRunningStatusInAG)
		{
			try 
				{	
					repo.GroomingOptionWindow.txtAggregationCurrentlyRunningInfo.WaitForExists(new Duration(1000000));
					
					if (repo.GroomingOptionWindow.txtAggregationCurrentlyRunning.TextValue == strCurrentRunningStatusInAG)
						Reports.ReportLog("Successfully Verified Current Running Status In Aggregation As: " + repo.GroomingOptionWindow.txtAggregationCurrentlyRunning.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Failed to Verify Current Running Status In Aggregation As: " + strCurrentRunningStatusInAG, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
			catch (Exception ex)
				{
					throw new Exception("Failed : VerifyCurrentRunningStatusInAggregation :" + ex.Message);
				}
		}
		
			public static void VerifyValuesInRepositoryTable()
		{
			try 
			{
				string query = "select * from RepositoryInfo";
	        	DataTable dt = DBOperations.GetData(query);
	        	if(dt != null && dt.Rows.Count > 0)
	        	{   
	        		string GroomMetricsValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[0]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
	        		string GroomQueryAggregationValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[1]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
	        		string GroomAlertsValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[2]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
	        		string GroomPrescriptiveAnalysisValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[3]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
	        		string AggregateForecastingValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[4]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
	        		string GroomForecastingValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[5]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
	        		
	        		if(repo.GroomingOptionWindow.GroomStandardMetrixAndBaseline.TextValue.Equals(GroomMetricsValue))
	        			Reports.ReportLog("Groom standard Metrics and baseline Data is Displaying : " + repo.GroomingOptionWindow.GroomStandardMetrixAndBaseline.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
					{
						Reports.ReportLog("Groom standard Metrics value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Validate.AttributeEqual(repo.GroomingOptionWindow.GroomStandardMetrixAndBaselineInfo, "Text", GroomMetricsValue);
					}
					
					if(repo.GroomingOptionWindow.GroomInactiveAlert.TextValue.Equals(GroomQueryAggregationValue))
	        			Reports.ReportLog("Groom Inactive Alert is Displaying : " + repo.GroomingOptionWindow.GroomInactiveAlert.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
					{
						Reports.ReportLog("Groom Inactive Alert value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Validate.AttributeEqual(repo.GroomingOptionWindow.GroomInactiveAlertInfo, "Text", GroomQueryAggregationValue);
					}
					
					if(repo.GroomingOptionWindow.AggregateQueryDataInto.TextValue.Equals(GroomAlertsValue))
						Reports.ReportLog(" Aggregate Query Data Into is Displaying : " + repo.GroomingOptionWindow.AggregateQueryDataInto.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
					{
						Reports.ReportLog(" Aggregat eQuery Data Into value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Validate.AttributeEqual(repo.GroomingOptionWindow.AggregateQueryDataIntoInfo, "Text", GroomAlertsValue);
					}

					if(repo.GroomingOptionWindow.GroomPrescriptiveAnalysis.TextValue.Equals(GroomPrescriptiveAnalysisValue))
	        			Reports.ReportLog(" GroomPrescriptiveAnalysis is Displaying : " + repo.GroomingOptionWindow.GroomPrescriptiveAnalysis.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
					{
						Reports.ReportLog(" GroomPrescriptiveAnalysis value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Validate.AttributeEqual(repo.GroomingOptionWindow.GroomPrescriptiveAnalysisInfo, "Text", GroomPrescriptiveAnalysisValue);
					}
					
					if(repo.GroomingOptionWindow.AggregateTextbox.TextValue.Equals(AggregateForecastingValue))
	        			Reports.ReportLog(" Aggregate Forcasting data is Displaying : " + repo.GroomingOptionWindow.AggregateTextbox.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
					{
						Reports.ReportLog(" Aggregate Forcasting data value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Validate.AttributeEqual(repo.GroomingOptionWindow.AggregateTextboxInfo, "Text", AggregateForecastingValue);
					}
					
					if(repo.GroomingOptionWindow.GroomForecastTextbox.TextValue.Equals(GroomForecastingValue))
	        			Reports.ReportLog(" Groom Forecasting is Displaying : " + repo.GroomingOptionWindow.GroomForecastTextbox.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
					{
						Reports.ReportLog(" Groom Forecasting value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Validate.AttributeEqual(repo.GroomingOptionWindow.GroomForecastTextboxInfo, "Text", GroomForecastingValue);
					}
	        	}
	        		
	        	else
	        		Reports.ReportLog("Records is not present in RepositoryInfo Table " , Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
	        	
	        	
			} 
			catch (Exception ex)
			{
				throw new Exception("Failed : VerifyValuesInRepositoryTable :" + ex.Message);
			}
		}
 		
		public static void VerifyDefaultMetricsDataAs90Days()
		{
			try 
			{
				repo.GroomingOptionWindow.SelfInfo.WaitForExists(new Duration(1000000));
				
				Validate.AttributeContains(repo.GroomingOptionWindow.GroomStandardMetrixAndBaselineInfo, "Text", "90");
				
				if (repo.GroomingOptionWindow.GroomStandardMetrixAndBaseline.TextValue.Equals("90") )
					Reports.ReportLog("Groom standard Metrics and baseline Data is Displaying : " + repo.GroomingOptionWindow.GroomStandardMetrixAndBaseline.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				else
					Reports.ReportLog("Groom standard Metrics and baseline Data is Displaying : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
			} 
			catch (Exception ex)
			{
				throw new Exception("Failed : VerifyDefaultMetricsDataAs90Days :" + ex.Message);
			}
		}
 		
		
		public static void VerifyCompletionStatusInAggregation(string strCompletionStatusInAG)
		{
			try 
				{	
					repo.GroomingOptionWindow.txtAggregationCompletionStatusInfo.WaitForExists(new Duration(1000000));
					
					if (repo.GroomingOptionWindow.txtAggregationCompletionStatus.TextValue == strCompletionStatusInAG)
						Reports.ReportLog("Successfully Verified Completion Status In Aggregation As: " + repo.GroomingOptionWindow.txtAggregationCompletionStatus.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Failed to Verify Completion Status In Aggregation As: " + strCompletionStatusInAG, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
			catch (Exception ex)
				{
					throw new Exception("Failed : VerifyCompletionStatusInAggregation :" + ex.Message);
				}
		}
		
		
    }
}
