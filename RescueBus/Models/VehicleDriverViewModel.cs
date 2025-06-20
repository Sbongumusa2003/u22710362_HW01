using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class VehicleDriverViewModel
    {
        public List<Vehicle> Vehicles { get; set; }

        public List<Driver> Drivers { get; set; }
    }
}