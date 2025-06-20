using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.IO;

namespace RescueBus.Models
{
    public class VehicleRepository
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>()
        {
            new Vehicle {
                VehicleID = 1,
                Type = "Ambulance",
                RegistrationNumber = "XYZ",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/vehicle1.jpg"),
                ServiceID = 1
            },
            new Vehicle {
                VehicleID = 2,
                Type = "Ambulance",
                RegistrationNumber = "ABC",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/vehicle2.jpg"),
                ServiceID = 2
            },
            new Vehicle {
                VehicleID = 3,
                Type = "Patient Transport",
                RegistrationNumber = "DEF",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/vehicle2.jpg"),
                ServiceID = 4
            },
            new Vehicle {
                VehicleID = 5,
                Type = "Utility Vehicle",
                RegistrationNumber = "GHI",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/vehicle1.jpg"),
                ServiceID = 4
            },
        };

        public static class ImageHelper
        {
            public static string ImageToBase64(string relativePath)
            {
                var absolutePath = HostingEnvironment.MapPath(relativePath);
                if (absolutePath == null || !File.Exists(absolutePath))
                    return null;

                byte[] imageBytes = File.ReadAllBytes(absolutePath);
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}