using System.Net.Security;
using System.Security;

namespace okul
{
    internal class main
    {

        static void Main(string[] args)
        {
            
            
            
            Console.WriteLine("do you want to create a new user ?");
            Console.WriteLine("Y/N");
            string yesNo = Console.ReadLine().ToLower();
            

            if (yesNo != "y")
            {
                if (yesNo != "n")
                {
                    if (yesNo != "deletea")
                    {
                        yesNo = "";
                    }
                }
            }


            while (yesNo == "")
            {
                Console.WriteLine("plesea enter a correct value Y/N");
                yesNo = Console.ReadLine();

                if (yesNo != "y")
                {
                    if (yesNo != "n")
                    {
                        if (yesNo != "deletea")
                        {
                            yesNo = "";
                        }
                        
                    }
                }
            }


            while (yesNo == "y")
            {
                Role role = new Role();

                

                if (role.role == "stuedent")
                {
                    fileCheckerFixer asd = new fileCheckerFixer("C:\\Users\\segad\\source\\repos\\okul\\stuedent.txt");
                    Stuedent stuedent = new Stuedent();
                    string[] data = { "name: " + stuedent.name, "surname: " + stuedent.surname, "gender: " + stuedent.gender, stuedent.age + " years old", "birthday: " + stuedent.bDay, "grade: " + stuedent.grade, "***********************" };
                    System.IO.File.WriteAllLines(@"C:\Users\segad\source\repos\okul\stuedent.txt", data);
                }

                if (role.role == "teacher")
                {
                    fileCheckerFixer asd = new fileCheckerFixer("C:\\Users\\segad\\source\\repos\\okul\\teacher.txt");
                    Teacher teacher = new Teacher();
                    string[] data1 = { "name: " + teacher.name, "surname: " + teacher.surname, "gender: " + teacher.gender, teacher.age + " years old", "birthday: " + teacher.bDay, "branch: " + teacher.branch, "phone number" + teacher.pNumber, "pay" + teacher.pay, "***********************" };
                    System.IO.File.WriteAllLines(@"C:\Users\segad\source\repos\okul\teacher.txt", data1);
                }

                if (role.role == "manager")
                {
                    fileCheckerFixer asd = new fileCheckerFixer("C:\\Users\\segad\\source\\repos\\okul\\manager.txt");
                    Manager manager = new Manager();
                    string[] data2 = { "name: " + manager.name, "surname: " + manager.surname, "gender: " + manager.gender, manager.age + " years old", "birthday: " + manager.bDay, "branch: " + manager.branch, "phone number" + manager.pNumber, "pay" + manager.pay, "cv" + manager.cv, "***********************" };
                    System.IO.File.WriteAllLines(@"C:\Users\segad\source\repos\okul\manager.txt", data2);
                }

                Console.WriteLine("do you want to create an other user Y/N");
                yesNo = Console.ReadLine();

                if (yesNo != "y")
                {
                    if (yesNo != "n")
                    {
                        yesNo = "";
                    }
                }

                while (yesNo == "")
                {
                    Console.WriteLine("plesea enter a correct value Y/N");
                    yesNo = Console.ReadLine();

                    if (yesNo != "y")
                    {
                        if (yesNo != "n")
                        {
                            yesNo = "";
                        }
                    }
                }

            }


            if (yesNo == "n")
            {

            }


            else if (yesNo == "deletea")
            {
                System.IO.File.Delete(@"C:\Users\segad\source\repos\okul\stuedent.txt");
                System.IO.File.Delete(@"C:\Users\segad\source\repos\okul\teacher.txt");
                System.IO.File.Delete(@"C:\Users\segad\source\repos\okul\manager.txt");

            }
        }
    }


    
}