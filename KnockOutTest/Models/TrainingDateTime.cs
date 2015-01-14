using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnockOutTest.Models
{
    public class TrainingDateTime
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public TrainingDateTime(string startDate, string endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
