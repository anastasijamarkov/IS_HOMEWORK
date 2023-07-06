using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketShopAdminApplication.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string MovieName { get; set; }
        public string MovieImage { get; set; }
        
        public string MovieDescription { get; set; }
        public string Genre { get; set; }
        public int TicketPrice { get; set; }

        public DateTime DateValid { get; set; }

        public int Rating { get; set; }
    }
}
