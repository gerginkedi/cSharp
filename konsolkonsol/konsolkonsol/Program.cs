using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


ConsoleKey consoleKey = Console.ReadKey().Key;
ConsoleKey consoleKey2 = Console.ReadKey().Key;

//if (consoleKey == ConsoleKey.L && consoleKey2 == ConsoleKey.P)
//{

//    //var prs = new ProcessStartInfo(@"C:\Program Files\BraveSoftware\Brave-Browser-Beta\Application");
//    //prs.Arguments = "https://youtube.com";

//    try
//    {
//        Process process = new Process();
//        process.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
//        //process.StartInfo.FileName = "CMD.exe";
//        //process.StartInfo.Arguments = @"C:\Users\segad\OneDrive\Masaüstü\assa.txt";
//        process.StartInfo.Arguments = "https://translate.google.com/?hl=tr";
//        process.Start();
//    }
//    catch (System.ComponentModel.Win32Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}



if (consoleKey == ConsoleKey.L && consoleKey2 == ConsoleKey.P)
{

    //var prs = new ProcessStartInfo(@"C:\Program Files\BraveSoftware\Brave-Browser-Beta\Application");
    //prs.Arguments = "https://youtube.com";

    try
    {
        Process process = new Process();
        //process.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
        process.StartInfo.FileName = "CMD.exe";
        process.StartInfo.Arguments = @"C:\Users\segad\OneDrive\Masaüstü\assa.txt";
        //process.StartInfo.Arguments = "https://translate.google.com/?hl=tr";
        process.Start();
    }
    catch (System.ComponentModel.Win32Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}