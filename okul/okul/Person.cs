using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace okul
{
    internal class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string bDay { get; set; }
        public Person()
        {
            Console.WriteLine("enter your name");
            name = Console.ReadLine();

            Console.WriteLine("enter your surname");
            surname = Console.ReadLine();

            Console.WriteLine("enter your gender");
            gender = Console.ReadLine();

            Console.WriteLine("enter your age");
            age = Console.ReadLine();

            Console.WriteLine("enter your birthday");
            bDay = Console.ReadLine();

            while (name == "" || surname == "" || gender == "" || age == "" || bDay == "")
            {
                if (name == "")
                {
                    Console.WriteLine("please check your name");
                    name = Console.ReadLine();
                }

                if (surname == "")
                {
                    Console.WriteLine("please check your surname");
                    surname = Console.ReadLine();
                }

                if (gender == "")
                {
                    Console.WriteLine("please check your gender");
                    gender = Console.ReadLine();
                }

                if (age == "")
                {
                    Console.WriteLine("please check your age");
                    age = Console.ReadLine();
                }

                if (bDay == "")
                {
                    Console.WriteLine("please cehck your birthday");
                    bDay = Console.ReadLine();
                }

            }
        }
    }
}