using System;
using System.Collections.Generic;


namespace BusTicketBookingApplication
{
    interface IBusManager
    {
        void ModifyTicketDetail();
        void AddBusDetails();
        void RemoveTicketDetail();
    }

    class BusManager:IBusManager
    {

        public void ModifyTicketDetail()
        {
            Console.WriteLine("Enter Bus Id to be deleted");
            int modifyItemNo = int.Parse(Console.ReadLine());
            BusRepositary.ModifyBusDetails(modifyItemNo);
        }
        public void RemoveTicketDetail()
        {
            Console.WriteLine("Bus database");
            BusRepositary.DisplayBusInfo();
            Console.WriteLine("Enter Bus Id to be deleted");
            int deleteItemNo = int.Parse(Console.ReadLine());
            BusRepositary.DeleteBusDetails(deleteItemNo);
        }
        public void AddBusDetails()
        {
            
            Console.WriteLine("Enter Bus Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Travels name ");
            string travelsName = Console.ReadLine();
            Console.WriteLine("Enter source city: ");
            string sourceCity = Console.ReadLine().ToLower();
            Console.WriteLine("Enter destination city: ");
            string destinationCity = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Number of tickets available: ");
            byte availableTickets = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticket Price: ");
            double ticketPrice = double.Parse(Console.ReadLine());
            
            BusRepositary.AddTicket(new Bus(id,travelsName, sourceCity, destinationCity, availableTickets, ticketPrice));
        }
        internal static void SearchBus()
        {
            Console.WriteLine("Enter source city: ");
            string sourceCity = Console.ReadLine().ToLower();
            Console.WriteLine("Enter destination city: ");
            string destinationCity = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Number of tickets");
            byte totalTicketsNeeded = byte.Parse(Console.ReadLine());
            BusRepositary.SearchDetails(sourceCity, destinationCity, totalTicketsNeeded);
        }
        internal static bool PaymentLogin()
        {
            Console.WriteLine("1.Login\n2.Signup");
            byte choice = byte.Parse(Console.ReadLine());
            if (choice == 1)
            {
                LoginManager.CheckLogin();
                return true;
            }
            else if (choice == 2)
            {
                UserRepositary.SignUp();
                Console.WriteLine("Login to continue");
                LoginManager.CheckLogin();
                return true;
            }
            else
                Console.WriteLine("Enter correct no");
                return false;
        }
    }
}
