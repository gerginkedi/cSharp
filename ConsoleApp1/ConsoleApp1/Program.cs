using ConsoleApp1;
using System;
using static ConsoleApp1.Persons;

class Program
    {   
        public static void Main(int[] args)
        {
            Persons ömer = new Persons();
            ömer.birthDate = 2007;
            
            DateTime myDateTime = DateTime.Now;
            string year = myDateTime.Year.ToString();
            int yearInt = Int32.Parse(year);
            Console.WriteLine(yearInt - ömer.birthDate);
           
            System.Console.WriteLine(Persons.BloodGroups.ZeroPositive);
        }
    }