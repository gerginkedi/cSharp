using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul
{
    
    internal class Role
    {
        public string role { get; set; }
        public Role()
        {
            Console.WriteLine("choose your role");
            Console.WriteLine("stuedent     teacher     manager");
            role = Console.ReadLine();
            if (role != "stuedent")
            {
                if (role != "manager")
                {
                    if (role != "teacher")
                    {
                        role = "";
                    }
                }
            }
            while (role == "")
            {
                if (role != "stuedent")
                {
                    if (role != "manager")
                    {
                        if (role != "teacher")
                        {
                            Console.WriteLine("please enter a correct role");
                            Console.WriteLine("stuedent     teacher     manager");
                            role = Console.ReadLine();
                            if (role != "stuedent")
                            {
                                if (role != "manager")
                                {
                                    if (role != "teacher")
                                    {
                                        role = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
