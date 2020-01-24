using System;
using System.Collections.Generic;



namespace BusTicketBookingApplication
{
    class BusRepositary
    {
        static int count = 0;
        static bool flag;
        static int value;
        static List<Bus> BusList = new List<Bus>();

        static BusRepositary()
        {

            BusList.Add(new Bus(1, "A1 travels", "coimbatore", "chennai", 55, 550));
            BusList.Add(new Bus(2, "Jayam travels", "chennai", "coimbatore", 56, 550));

        }
        internal static void DisplayBusInfo()
        {
            foreach (Bus list in BusList)
            {
                Console.WriteLine("Buses available");
                Console.WriteLine("Source city:{0}\nDestination City:{1}\nNumber of Tickets Available:{2}\nPrice Of Ticket:{3}", list.SourceCity, list.DestinationCity, list.AvailableTickets, list.TicketPrice);

            }
        }
        internal static void AddTicket(Bus ticket)
        {
            BusList.Add(ticket);
        }

        internal static void DeleteBusDetails(int deleteItemNo)
        {

           
            foreach (Bus list in BusList)
            {
                count++;
                if ((list.BusId).Equals(deleteItemNo))
                {
                    flag = true;
                    Console.WriteLine("true");
                    value = count-1;
                    count = 0;
                    break;
                }
            }
            if (flag)
            {
                BusList.RemoveAt(value);
                flag = false;
            }
            foreach (Bus list in BusList)
            {
                Console.WriteLine("Items after removal");
                Console.WriteLine("ID:{0},Source city:{1}\nDestination City:{2}\nNumber of Tickets Available:{3}\nPrice Of Ticket:{4}", list.BusId, list.SourceCity, list.DestinationCity, list.AvailableTickets, list.TicketPrice);

            }
            
        }
        public static void ModifyBusDetails(int modifyItemNo)
        {
            foreach (Bus list in BusList)
            {
                count++;
                if ((list.BusId).Equals(modifyItemNo))
                {
                    flag = true;
                    Console.WriteLine("true");
                    value = count - 1;
                    count = 0;
                    break;
                }
            }
            
            if (flag)
            {
                Console.WriteLine("Enter Bus Id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Travels name ");
                string travelsName = Console.ReadLine();
                Console.WriteLine("Enter source city: ");
                string sourceCity = Console.ReadLine();
                Console.WriteLine("Enter destination city: ");
                string destinationCity = Console.ReadLine();
                Console.WriteLine("Enter Number of tickets available: ");
                byte availableTickets = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter Ticket Price: ");
                double ticketPrice = double.Parse(Console.ReadLine());
                BusList[value] = (new Bus(id, travelsName, sourceCity, destinationCity, availableTickets, ticketPrice));
                flag = false;
            }
        }
        internal static void SearchDetails(string SourceCity, string DestinationCity, byte totalTicketsNeeded)
        {
            bool val = true;
            if (BusList.Count == 0)
            {
                Console.WriteLine("No buses found!!");
            }
            foreach (Bus list in BusList)
            {
                if (list.SourceCity.Equals(SourceCity) && list.DestinationCity.Equals(DestinationCity))
                {
                    count++;
                    val = false;
                    Console.WriteLine("Travel's Name:{0},Number of Tickets Available:{1}\nPrice Of Ticket:{2},Travels Id:{3}", list.TravelsName, list.AvailableTickets, list.TicketPrice, list.BusId);

                    Console.WriteLine("Choose bus id to book");
                    int choice = int.Parse(Console.ReadLine());
                    if ((list.BusId).Equals(choice))
                    {
                        flag = true;
                        // Console.WriteLine("true");
                        value = count - 1;
                        count = 0;


                        if (totalTicketsNeeded > BusList[value].AvailableTickets)
                        {
                            Console.WriteLine("Sorry! the ticket availabilty is only " + list.AvailableTickets);
                        }
                        else
                        {

                            list.AvailableTickets = (byte)(list.AvailableTickets - totalTicketsNeeded);
                            if (LoginManager.session == "logged")
                            {
                                Console.WriteLine("Your net amount is " + totalTicketsNeeded * list.TicketPrice);
                            }
                            else
                            {
                                Console.WriteLine("Login to continue");
                                if (BusManager.PaymentLogin())
                                {
                                    LoginManager.session = "finallogin";
                                    Console.WriteLine("Your net amount is " + totalTicketsNeeded * list.TicketPrice);
                                }

                            }

                        }

                    }
                    break;
                }
            }
            if (val)
            {
                Console.WriteLine("OOPS!No Buses found!");
            }
        }
    }
}


