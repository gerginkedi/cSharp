using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace okul
{
    internal class Manager : Teacher
    {
        public string cv { get; set; }

        public Manager()
        {
            Console.WriteLine("write your cv");
            cv = Console.ReadLine();

            

            pay = "40000";
            while (cv == "")
            {
                Console.WriteLine("write your cv");
                cv = Console.ReadLine();
            }
        }

    }
}
