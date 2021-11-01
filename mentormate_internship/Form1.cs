using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Windows;
namespace mentormate_internship
{
    public partial class s : Form
    {
        //input.txt file must be located in bin\\debug in root directory.
        static string input = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\input.txt");
        private List<MeetingRoom> list = JsonConvert.DeserializeObject<List<MeetingRoom>>(input);
        private Meeting meeting;
        public s()
        {
            InitializeComponent();
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            if (this.participants_number.Value == 0)
            {
                MessageBox.Show(this, "Minimum number of participants is 1", "Warning", MessageBoxButtons.OK);
            }
            else if (this.meeting_duration.Value < 15)
            {
                MessageBox.Show(this, "Minimum meeting duration is 15 minutes", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                this.available_rooms.Items.Clear();
                this.available_rooms.Text = null;
                this.available_time_slots.Items.Clear();
                this.available_time_slots.Text = null;

                meeting = new Meeting(
                    (int)this.participants_number.Value,
                    this.time_slot_date.Value,
                    (int)this.meeting_duration.Value);
                populateAvailableMeetings(list, meeting);
            }
        }

        private void available_rooms_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MeetingRoom selectedRoom = (MeetingRoom)this.available_rooms.SelectedItem;
            this.available_time_slots.Items.Clear();
            this.available_time_slots.Text = null;
            populateAvailableTimeSlots(selectedRoom, meeting);
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {
            if (this.available_rooms.SelectedItem == null || this.available_time_slots.SelectedItem == null)
            {
                MessageBox.Show(this, "No room or time slot selected.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                MeetingRoom selectedRoom = (MeetingRoom)this.available_rooms.SelectedItem;
                Dates selectedDateForMeeting = (Dates)this.available_time_slots.SelectedItem;
                selectedRoom.addAMeeting(selectedDateForMeeting);
                System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "\\input.txt", JsonConvert.SerializeObject(list));
                this.available_rooms.Items.Clear();
                this.available_rooms.Text = null;
                this.available_time_slots.Items.Clear();
                this.available_time_slots.Text = null;
                populateAvailableMeetings(list, meeting);
                populateAvailableTimeSlots(selectedRoom, meeting);
            }
        }

        private void populateAvailableMeetings(List<MeetingRoom> list, Meeting meeting)
        {
            foreach (MeetingRoom room in list)
            {
                if (room.getPossibleTimeSlotsForAMeeting(meeting).Count() > 0)
                    this.available_rooms.Items.Add(room);
            }
        }
        private void populateAvailableTimeSlots(MeetingRoom selectedRoom, Meeting meeting)
        {
            foreach (Dates dates in selectedRoom.getPossibleTimeSlotsForAMeeting(meeting))
            {
                this.available_time_slots.Items.Add(dates);
            }
        }
    }
}
