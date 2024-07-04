//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Diagnostics;

//class OpenWeb
//{

//    static void Main(string[] args)
//    {
//        var prs = new ProcessStartInfo("chrome.exe");
//        prs.Arguments = "https://youtube.com";
        
//        try
//        {
//            Process.Start(prs);
//        }
//        catch (System.ComponentModel.Win32Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}