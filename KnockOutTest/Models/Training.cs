using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockOutTest.Models
{
    public class Training
    {
        public int TrainingId { get; set; }
        public string Name { get; set; }
        public List<TrainingDateTime> TrainingDateTimes { get; set; }

        public Training()
        {
            this.TrainingDateTimes = new List<TrainingDateTime>();
        }
    }
}