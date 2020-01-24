using System;


namespace BusTicketBookingApplication
{
    class UserDetails
    {
        internal string Name { set; get; }
        internal string Password { set; get; }
        internal string PhoneNo { set; get; }
        internal string Email { set; get; }

        internal UserDetails()
        {
            Console.WriteLine("Enter your Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your phone No");
            PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();
        }
          
    }
}
