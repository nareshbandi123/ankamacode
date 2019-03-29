
using System;


namespace AutomationSQLdm.Configuration
{
 
    public static class Config 
    {
        public static string AppPath = System.Configuration.ConfigurationManager.AppSettings["APP_PATH"].ToString();
        
		public static int ProcessID;
		public static string TestCaseName;
		
		public const string ServerOptions_CMWIN2016S8 = "CMWIN2016-S8";
		public const string ServerOptions_CMWIN2016SQL17 = "CMWIN2016SQL17";
		public const string ServerOptions_TMSSQL2016 = "T-MSSQL2016";
		
    }
}
