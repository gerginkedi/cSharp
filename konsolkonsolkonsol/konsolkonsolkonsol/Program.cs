using System.Diagnostics;

namespace konsolkonsolkonsol
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ConsoleKey consoleKey = Console.ReadKey().Key;
            ConsoleKey consoleKey2 = Console.ReadKey().Key;
            if (consoleKey == ConsoleKey.L && consoleKey2 == ConsoleKey.P)
            {
                

                
                Console.Clear();


                var linq = "asda";

                linq = linq.ToLower();

                Console.WriteLine("açmak istediğin sitenin adını gir gir çıkmak içinse exit yaz");
                Console.WriteLine("|---------|");
                Console.WriteLine("|YOUTUBE  |");
                Console.WriteLine("|TRANSLATE|");
                Console.WriteLine("|WHATSAPP |");
                Console.WriteLine("|---------|");
                
                while (linq != "exit")
                {
                    linq = Console.ReadLine();
                    if(linq != "youtube" || linq != "whatsapp" || linq != "translate")
                    {
                        while (linq != "youtube" || linq != "whatsapp" || linq != "translate")
                        {
                            Console.WriteLine("lütfen listedeki sitelerden birini giriniz");
                            linq = Console.ReadLine();
                            
                            if(linq == "youtube" || linq == "whatsapp" || linq == "translate" || linq == "exit")
                            {
                                break;
                            }
                        }
                    }
                    
                        
                    
                    
                    
                    try
                {
                    var folderPath = "C:\\Program Files\\BraveSoftware\\Brave-Browser-Beta\\Application\\brave.exe";
                    ProcessStartInfo startInfo = new ProcessStartInfo(folderPath);

                    string path = "";
                    if(linq== "exit")
                        {
                            break;
                        }
                        switch (linq)
                    {
                        case "youtube":
                            path = "https://www.youtube.com/";
                            break;
                        case "translate":
                            path = "https://translate.google.com/?hl=tr";
                            break;
                        case "whatsapp":
                            path = "https://web.whatsapp.com/";
                            break;
                    }

                    startInfo.Arguments = path;
                    //startInfo.Arguments = "https://translate.google.com/?hl=tr";
                    Process.Start(startInfo);


              


                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch
                {
                    Console.WriteLine("error");
                }
                
                }
            }
        }
    }
}