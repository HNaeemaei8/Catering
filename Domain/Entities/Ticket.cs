using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime DateOfDeparture  { get; set; }
        public DateTime DepartureTime { get; set; }
        public string FlightClass { get; set; }
        public decimal Price { get; set; }


    }
}
