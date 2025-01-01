using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.AbstractFactory;
using Mini_Project.ConcreateProducts;
using Mini_Project.Factories;

namespace Mini_Project
{
    class Client
    {
        
        public static void Main()
        {
                Console.WriteLine("==============Railway Reseravtion===============");
                Console.WriteLine();
                Console.WriteLine("Choose ADMIN || USER || EXIT");
                string adminUser = Console.ReadLine();
                string temp = adminUser.ToLower();
                ITrainDetails itrainDetails;

                if (temp == "admin")
                {
                    itrainDetails = new AdminFactory();
                    IAdmin Adminaction = itrainDetails.CreateAdmin();
                    Display.Adisplay();
                }
                else if (temp == "user")
                {
                    itrainDetails = new UserFactory();
                    IUser Useraction = itrainDetails.CreateUser();
                    Display.Udisplay();
                }
                else if (temp == "exit")
                {
                    return;
                    Console.Read();
                }
        }
        
    }
}
