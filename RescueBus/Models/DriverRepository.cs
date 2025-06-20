using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static RescueBus.Models.VehicleRepository;

namespace RescueBus.Models
{
    public class DriverRepository
    {
        public static List<Driver> Drivers = new List<Driver>
        {
            new Driver
            {
                DriverID = 1,
                FirstName = "John",
                LastName = "Smith",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0812345678",
                ServiceID = 1
            },
            new Driver
            {
                DriverID = 2,
                FirstName = "Sarah",
                LastName = "Mokoena",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0823456789",
                ServiceID = 2
            },
            new Driver
            {
                DriverID = 3,
                FirstName = "Peter",
                LastName = "Zulu",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0834567890",
                ServiceID = 3
            },
            new Driver
            {
                DriverID = 4,
                FirstName = "Lerato",
                LastName = "Khumalo",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0845678901",
                ServiceID = 4
            },
            new Driver
            {
                DriverID = 5,
                FirstName = "James",
                LastName = "van der Merwe",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0856789012",
                ServiceID = 5
            }
        };

    }
}