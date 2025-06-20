using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class ReasonRepository
    {
        public static List<Reason> Reasons = new List<Reason>
        {
            new Reason
            {
                ReasonID = 1,
                Description = "Medical Emergency"
            },
            new Reason
            {
                ReasonID = 2,
                Description = "Non-Medical Emergency"
            },
            new Reason
            {
                ReasonID = 3,
                Description = "Routine Transport"
            },
            new Reason
            {
                ReasonID = 4,
                Description = "Other"
            }
        };
    }
}