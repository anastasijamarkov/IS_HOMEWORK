﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketShopAdminApplication.Models
{
    public class TicketShopApplicationUser
    {
        public string NormalizedEmail { get; set; }
        public string Email { get; set; }
        public string NormalizedUserName { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
    }
}
