﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string Type { get; set; }
        public string RegistrationNumber { get; set; }
        public string ImagePath { get; set; }
        public int ServiceID { get; set; }
    }
}