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
                FirstName = "Sam",
                LastName = "Johnson",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/Driver1.jpeg"),
                PhoneNumber = "0812345678",
                ServiceID = 1
            },
            new Driver
            {
                DriverID = 2,
                FirstName = "Ayanda",
                LastName = "Zulu",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/Driver2.jpeg"),
                PhoneNumber = "0823456789",
                ServiceID = 2
            },
            new Driver
            {
                DriverID = 3,
                FirstName = "Peter",
                LastName = "Mbatha",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/Driver 3.jpeg"),
                PhoneNumber = "0612009709",
                ServiceID = 3
            },
            new Driver
            {
                DriverID = 4,
                FirstName = "Sam",
                LastName = "Khumalo",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/Driver 4.jpeg"),
                PhoneNumber = "0845678901",
                ServiceID = 4
            },
            new Driver
            {
                DriverID = 5,
                FirstName = "MJ",
                LastName = "van der Merwe",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/Driver 5.jpeg"),
                PhoneNumber = "0856789012",
                ServiceID = 5
            }
        };

    }
}