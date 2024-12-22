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
                Console.WriteLine("Enter ADMIN || USER || EXIT");
                string adminUser = Console.ReadLine();
                string temp = adminUser.ToLower();
                ITrainDetails itrainDetails;

                if (temp == "admin")
                {
                    itrainDetails = new AdminFactory();
                    IAdmin Adminaction = itrainDetails.CreateAdmin();
                    Console.WriteLine("Choose 1.ADD || 2.MODIFY || 3.DELETE || 4.EXIT");
                    int choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            Adminaction.AddTrains();
                            break;
                        case 2:
                            Adminaction.ModifyTrains();
                            break;
                        case 3:
                            Adminaction.DeleteTrains();
                            break;
                        case 4:
                            Console.WriteLine("========================================================================");
                            Main();
                            break;
                    }
                }
                else if (temp == "user")
                {
                    itrainDetails = new UserFactory();
                    IUser Useraction = itrainDetails.CreateUser();
                    Console.WriteLine("Choose 1.BOOK_TICKET || 2.CANCEL_TICKET || 3.SHOW_TRAINS || 4.USER_BOOKING || 5.EXIT");
                    int choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            Useraction.BookTickets();
                            break;
                        case 2:
                            Useraction.CancelTickets();
                            break;
                        case 3:
                            Useraction.ShowAllTrains();
                            break;
                        case 4:
                            Useraction.User_Booking();
                            break;
                        case 5:
                            Console.WriteLine("=====================================================================");
                            Main();
                            break;
                    }
                }
                else if (temp == "exit")
                {
                    return;
                    Console.Read();
                }
        }
        
    }
}
