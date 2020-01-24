using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketBookingApplication
{
    class Operation
    {
        internal static void AdminOperation() 
        {
            bool count = true;
            byte choice;
            BusManager busManager = new BusManager();
            while (count)
            {
                Console.WriteLine("1.Add Ticket Details\n2.Update Ticket Details\n3.Search Bus to book ticket\n4.Delete Details\n5.Log out");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        busManager.AddBusDetails();
                        break;
                    case 2:
                        busManager.ModifyTicketDetail();
                        break;

                    case 3:
                        BusManager.SearchBus();
                        break;
                    case 4:
                        busManager.RemoveTicketDetail();
                        break;
                    case 5:
                        LoginManager.session = "Logged out";
                        count = false;
                        break;
                    default:
                        Console.WriteLine("enter correct number");
                        break;
                }
            }
        }
    }
}
