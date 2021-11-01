
namespace mentormate_internship
{
    partial class s
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.select_button = new System.Windows.Forms.Button();
            this.participants_number = new System.Windows.Forms.NumericUpDown();
            this.number_of_participants_label = new System.Windows.Forms.Label();
            this.time_slot_date = new System.Windows.Forms.DateTimePicker();
            this.time_slot_label = new System.Windows.Forms.Label();
            this.meeting_duration_label = new System.Windows.Forms.Label();
            this.meeting_duration = new System.Windows.Forms.NumericUpDown();
            this.available_rooms_label = new System.Windows.Forms.Label();
            this.available_time_slots_label = new System.Windows.Forms.Label();
            this.available_rooms = new System.Windows.Forms.ComboBox();
            this.available_time_slots = new System.Windows.Forms.ComboBox();
            this.schedule_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.participants_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeting_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // select_button
            // 
            this.select_button.AccessibleName = "select_button";
            this.select_button.Location = new System.Drawing.Point(228, 210);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(177, 28);
            this.select_button.TabIndex = 0;
            this.select_button.Text = "Update Meeting Requirements";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // participants_number
            // 
            this.participants_number.AccessibleName = "participants_number";
            this.participants_number.Location = new System.Drawing.Point(62, 137);
            this.participants_number.Name = "participants_number";
            this.participants_number.Size = new System.Drawing.Size(120, 20);
            this.participants_number.TabIndex = 2;
            this.participants_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // number_of_participants_label
            // 
            this.number_of_participants_label.AccessibleName = "number_of_participants_label";
            this.number_of_participants_label.AutoSize = true;
            this.number_of_participants_label.Location = new System.Drawing.Point(58, 107);
            this.number_of_participants_label.Name = "number_of_participants_label";
            this.number_of_participants_label.Size = new System.Drawing.Size(114, 13);
            this.number_of_participants_label.TabIndex = 3;
            this.number_of_participants_label.Text = "Number of Participants";
            // 
            // time_slot_date
            // 
            this.time_slot_date.AccessibleName = "time_slot_date";
            this.time_slot_date.Location = new System.Drawing.Point(228, 137);
            this.time_slot_date.Name = "time_slot_date";
            this.time_slot_date.Size = new System.Drawing.Size(143, 20);
            this.time_slot_date.TabIndex = 4;
            // 
            // time_slot_label
            // 
            this.time_slot_label.AccessibleName = "time_slot_label";
            this.time_slot_label.AutoSize = true;
            this.time_slot_label.Location = new System.Drawing.Point(262, 107);
            this.time_slot_label.Name = "time_slot_label";
            this.time_slot_label.Size = new System.Drawing.Size(77, 13);
            this.time_slot_label.TabIndex = 5;
            this.time_slot_label.Text = "Time Slot Date";
            // 
            // meeting_duration_label
            // 
            this.meeting_duration_label.AccessibleName = "meeting_duration_label";
            this.meeting_duration_label.AutoSize = true;
            this.meeting_duration_label.Location = new System.Drawing.Point(414, 107);
            this.meeting_duration_label.Name = "meeting_duration_label";
            this.meeting_duration_label.Size = new System.Drawing.Size(88, 13);
            this.meeting_duration_label.TabIndex = 7;
            this.meeting_duration_label.Text = "Meeting Duration";
            // 
            // meeting_duration
            // 
            this.meeting_duration.AccessibleName = "meeting_duration";
            this.meeting_duration.Location = new System.Drawing.Point(402, 137);
            this.meeting_duration.Name = "meeting_duration";
            this.meeting_duration.Size = new System.Drawing.Size(120, 20);
            this.meeting_duration.TabIndex = 6;
            this.meeting_duration.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // available_rooms_label
            // 
            this.available_rooms_label.AccessibleName = "available_rooms_label";
            this.available_rooms_label.AutoSize = true;
            this.available_rooms_label.Location = new System.Drawing.Point(556, 107);
            this.available_rooms_label.Name = "available_rooms_label";
            this.available_rooms_label.Size = new System.Drawing.Size(86, 13);
            this.available_rooms_label.TabIndex = 10;
            this.available_rooms_label.Text = "Available Rooms";
            // 
            // available_time_slots_label
            // 
            this.available_time_slots_label.AccessibleName = "available_time_slots_label";
            this.available_time_slots_label.AutoSize = true;
            this.available_time_slots_label.Location = new System.Drawing.Point(712, 107);
            this.available_time_slots_label.Name = "available_time_slots_label";
            this.available_time_slots_label.Size = new System.Drawing.Size(102, 13);
            this.available_time_slots_label.TabIndex = 11;
            this.available_time_slots_label.Text = "Available Time Slots";
            // 
            // available_rooms
            // 
            this.available_rooms.AccessibleName = "available_rooms";
            this.available_rooms.FormattingEnabled = true;
            this.available_rooms.Location = new System.Drawing.Point(559, 136);
            this.available_rooms.Name = "available_rooms";
            this.available_rooms.Size = new System.Drawing.Size(121, 21);
            this.available_rooms.TabIndex = 12;
            this.available_rooms.SelectionChangeCommitted += new System.EventHandler(this.available_rooms_SelectionChangeCommitted);
            // 
            // available_time_slots
            // 
            this.available_time_slots.AccessibleName = "available_time_slots";
            this.available_time_slots.FormattingEnabled = true;
            this.available_time_slots.Location = new System.Drawing.Point(715, 136);
            this.available_time_slots.Name = "available_time_slots";
            this.available_time_slots.Size = new System.Drawing.Size(121, 21);
            this.available_time_slots.TabIndex = 13;
            // 
            // schedule_button
            // 
            this.schedule_button.Location = new System.Drawing.Point(631, 210);
            this.schedule_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(134, 28);
            this.schedule_button.TabIndex = 14;
            this.schedule_button.Text = "Schedule Meeting";
            this.schedule_button.UseVisualStyleBackColor = true;
            this.schedule_button.Click += new System.EventHandler(this.schedule_button_Click);
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 386);
            this.Controls.Add(this.schedule_button);
            this.Controls.Add(this.available_time_slots);
            this.Controls.Add(this.available_rooms);
            this.Controls.Add(this.available_time_slots_label);
            this.Controls.Add(this.available_rooms_label);
            this.Controls.Add(this.meeting_duration_label);
            this.Controls.Add(this.meeting_duration);
            this.Controls.Add(this.time_slot_label);
            this.Controls.Add(this.time_slot_date);
            this.Controls.Add(this.number_of_participants_label);
            this.Controls.Add(this.participants_number);
            this.Controls.Add(this.select_button);
            this.Name = "s";
            this.Text = "MeetingScheduler";
            ((System.ComponentModel.ISupportInitialize)(this.participants_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeting_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.NumericUpDown participants_number;
        private System.Windows.Forms.Label number_of_participants_label;
        private System.Windows.Forms.DateTimePicker time_slot_date;
        private System.Windows.Forms.Label time_slot_label;
        private System.Windows.Forms.Label meeting_duration_label;
        private System.Windows.Forms.NumericUpDown meeting_duration;
        private System.Windows.Forms.Label available_rooms_label;
        private System.Windows.Forms.Label available_time_slots_label;
        private System.Windows.Forms.ComboBox available_rooms;
        private System.Windows.Forms.ComboBox available_time_slots;
        private System.Windows.Forms.Button schedule_button;
    }
}

