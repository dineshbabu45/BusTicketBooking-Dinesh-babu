using System;
using System.Collections;
using System.Collections.Generic;


namespace BusTicketBookingApplication
{
    class Bus
    {
        internal int BusId { get; set; }
        internal string TravelsName { get; set; }
        internal string SourceCity { set; get; }
        internal string DestinationCity { set; get; }
        internal byte AvailableTickets { set; get; }
        internal double TicketPrice { set; get; }
        

        internal Bus(int id,string travelsName,string sourceCity,string destinationCity, byte availableTickets, double ticketPrice)
        {
            this.TravelsName = travelsName;
            this.SourceCity = sourceCity;
            this.DestinationCity = destinationCity;
            this.AvailableTickets = availableTickets;
            this.TicketPrice = ticketPrice;
            this.BusId = id;
        }

        
    }
}
