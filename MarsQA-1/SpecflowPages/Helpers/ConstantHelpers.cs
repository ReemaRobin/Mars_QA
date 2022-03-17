using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";
        public static string Currentpath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

        //ScreenshotPath
        public static string ScreenshotPath = Currentpath + @"MarsQA-1\TestReports\Screenshots\";

        //ExtentReportsPath
        public static string ReportsPath = Currentpath + @"MarsQA-1\TestReports\Test_files" + "TestReport.html";

        //ReportXML Path
        public static string ReportXMLPath = Currentpath + @"MarsQA-1\TestReports" + "ExtentReport.xml";
    }
}