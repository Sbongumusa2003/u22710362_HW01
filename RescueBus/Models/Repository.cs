using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class Repository
    {
        public static List<Service> Services = new List<Service>
    {
        new Service { ServiceID = 1, Name = "Advanced Life Support" },
        new Service { ServiceID = 2, Name = "Basic Life Support" },
        new Service { ServiceID = 3, Name = "Patient Support" },
        new Service { ServiceID = 4, Name = "Medical Utility Vehicle" },
        new Service { ServiceID = 5, Name = "Event Medical Ambulance" },
        new Service { ServiceID = 6, Name = "Air Ambulance" }
    };
    }
}