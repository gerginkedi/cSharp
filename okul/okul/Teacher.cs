using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul
{
    internal class Teacher : Person
    {
        public string branch { get; set; }
        public string pNumber { get; set; }
        public string pay { get; set; } = "20000";
        public Teacher()
        {
            Console.WriteLine("enter your phone number");
            pNumber = Console.ReadLine();

            while (pNumber == "" || branch == "")
                {
                    if (pNumber == "")
                    {
                        Console.WriteLine("please check your phone number");
                        pNumber = Console.ReadLine();
                    }

                    if (branch == "")
                    {
                        Console.WriteLine("please check your branch");
                        branch = Console.ReadLine();
                    }
                    
                }
            }
    }
}
