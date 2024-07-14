using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul
{
    internal class Stuedent : Person
    {
        
        public string grade { get; set; }
        public Stuedent()
        {
            Console.WriteLine("enter your grade");
            grade = Console.ReadLine();
            while (grade == "")
            {
                Console.WriteLine("PLease check your grade");
                grade = Console.ReadLine();
            }
        }
    }
}
