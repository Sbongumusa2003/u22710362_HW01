using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class BookingConfirmedViewModel
    {
        public Booking Booking { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}