using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentormate_internship
{
    public class Meeting
    {
        public int requiredCapacity;
        public int requiredDurationInMinutes;
        public DateTime requiredDay;

        public Meeting(int requiredCapacity, DateTime requiredDay, int requiredDurationInMinutes)
        {
            this.requiredCapacity = requiredCapacity;
            this.requiredDay = requiredDay;
            this.requiredDurationInMinutes = requiredDurationInMinutes;
        }
    }
}
