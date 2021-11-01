using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentormate_internship
{
    public class MeetingRoom

    {
        public string roomName { get; set; }
        public int capacity { get; set; }
        public DateTime availableFrom { get; set; }
        public DateTime availableTo { get; set; }
        public List<Dates> schedule { get; set; }

        public override string ToString()
        {
            return this.roomName;
        }

        public DateTime getStartingHoursForADay(DateTime day)
        {
            DateTime startOfDay = new DateTime(
                day.Year,
                day.Month,
                day.Day,
                this.availableFrom.Hour,
                this.availableFrom.Minute,
                this.availableFrom.Second);
            return startOfDay;
        }

        public DateTime getEndingHoursForADay(DateTime day)
        {
            DateTime endOfDay = new DateTime(
                day.Year,
                day.Month,
                day.Day,
                this.availableTo.Hour,
                this.availableTo.Minute,
                this.availableTo.Second);
            return endOfDay;
        }

        public List<Dates> getAllScheduledMeetingsForADay(DateTime day)
        {
            List<Dates> remaining = new List<Dates>();

            foreach (Dates pair in this.schedule)
            {
                if (day.Month == pair.from.Month && day.Day == pair.from.Day)
                    remaining.Add(pair);
            }

            return remaining;
        }

        public void addAMeeting(Dates selectedTimeForMeeting)
        {
            schedule.Add(selectedTimeForMeeting);
            this.schedule = this.schedule.OrderBy(x => x.from).ToList();
        }

        public List<Dates> getPossibleTimeSlotsForAMeeting(Meeting meeting)
        {
            List<Dates> possibleDates = new List<Dates>();

            if (meeting.requiredCapacity > this.capacity)
                return possibleDates;

            DateTime endOfDay = this.getEndingHoursForADay(meeting.requiredDay);
            Dates currentMeeting = new Dates(this.getStartingHoursForADay(meeting.requiredDay), meeting.requiredDurationInMinutes);
            List<Dates> allScheduledMeetings = this.getAllScheduledMeetingsForADay(meeting.requiredDay);

            if (allScheduledMeetings.Count() != 0)
            {
                foreach (Dates scheduledMeeting in allScheduledMeetings)
                {
                    while (currentMeeting.isBefore(scheduledMeeting))
                    {
                        possibleDates.Add(new Dates(currentMeeting));
                        currentMeeting.add15Minutes();
                    }

                    currentMeeting = new Dates(scheduledMeeting.to, meeting.requiredDurationInMinutes);
                }
            }

            while (currentMeeting.isBefore(endOfDay))
            {
                possibleDates.Add(new Dates(currentMeeting));
                currentMeeting.add15Minutes();
            }

            return possibleDates;
        }
    }
}
