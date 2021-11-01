using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentormate_internship
{
    public class Dates
    {
        public Dates() { }

        public DateTime from { get; set; }
        public DateTime to { get; set; }

        public Dates(DateTime from, DateTime to)
        {
            this.from = from;
            this.to = to;
        }

        public Dates(Dates date)
        {
            this.from = date.from;
            this.to = date.to;
        }

        public Dates(DateTime from, double duration)
        {
            this.from = from;
            this.to = from;
            this.to = to.AddMinutes(duration);
        }

        public void add15Minutes()
        {
            this.from = this.from.AddMinutes(15);
            this.to = this.to.AddMinutes(15);
        }

        public bool isBefore(Dates date)
        {
            if (this.from.CompareTo(date.from) < 0 &&
                this.to.CompareTo(date.from) <= 0)
                return true;
            else
                return false;
        }

        public bool isBefore(DateTime date)
        {
            if (this.from.CompareTo(date) < 0 &&
                this.to.CompareTo(date) <= 0)
                return true;
            else
                return false;
        }

        public bool isAfter(Dates date)
        {
            if (this.from.CompareTo(date.from) >= 0 &&
                this.to.CompareTo(date.from) > 0)
                return true;
            else
                return false;
        }

        public bool isAfter(DateTime date)
        {
            if (this.from.CompareTo(date) >= 0 &&
                this.to.CompareTo(date) > 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return this.from.ToLongTimeString();
        }
    }
}
