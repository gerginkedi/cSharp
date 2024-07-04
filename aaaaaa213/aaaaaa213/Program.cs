using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


ConsoleKey consoleKey = Console.ReadKey().Key;
ConsoleKey consoleKey2 = Console.ReadKey().Key;

if (consoleKey == ConsoleKey.L && consoleKey2 == ConsoleKey.P)
{

    var prs = new ProcessStartInfo(@"C:\Program Files\BraveSoftware\Brave-Browser-Beta\Application");
    prs.Arguments = "https://youtube.com";

    try
    {
        Process.Start(prs);
    }
    catch (System.ComponentModel.Win32Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.ReadKey();
