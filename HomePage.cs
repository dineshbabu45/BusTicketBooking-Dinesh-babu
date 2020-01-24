using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketBookingApplication
{
    class HomePage
    {
        
        internal void ViewHomePage()
        {
            bool count = true;
            while (count)
            {
                Console.WriteLine("------------Homepage----------");
                Console.WriteLine("1.Login\n2.SignUp\n3.Search Buses to book ticket\n4.Exit");
                try
                {
                    byte choice = Byte.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            LoginManager.CheckLogin();

                            break;
                        case 2:
                            UserRepositary.SignUp();

                            break;
                        case 3:

                            BusManager.SearchBus();

                            break;
                        case 4:
                            count = false;
                            break;
                        default:
                            Console.WriteLine("Enter correct number");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Enter correct input");
                }

            }
        }
    }
}
