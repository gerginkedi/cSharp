using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Person
    {
        
        public Gender gender;
        public int BirthYear;
        public string Name;
        public string Surname;
        public Months Month;
        public BloodGroups Blood;
        public void data()

        {


            DateTime now = DateTime.Now;
            string year = now.Year.ToString();
            int nowInt = Int32.Parse(year);



            int YearOld = (nowInt - BirthYear);
            
            if(YearOld > 18)
            {
            Console.WriteLine("Adult");
            }
            
            else
            {
            Console.WriteLine("kid");
            }
            
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Surname :"+ Surname);
            Console.WriteLine("Birth Year :"+BirthYear);
            Console.WriteLine("Blood Group : " + Blood);
            Console.WriteLine("Gender : "+gender);
            Console.WriteLine(YearOld+" Years Old");
            
        }
        public enum BloodGroups
        {
            ZeroNegative,
            ZeroPositive,
            ANegative,
            APositive,
            BNegative,
            BPositive,
            ABNegative,
            ABPositive


        }

        public enum Gender
    {
        Male,
        Female
    }
    public enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


    }

