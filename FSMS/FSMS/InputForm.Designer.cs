namespace FSMS
{
    partial class InputForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTheory = new System.Windows.Forms.TabPage();
            this.tabFlights = new System.Windows.Forms.TabPage();
            this.tabFinance = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTheoryTeacher = new System.Windows.Forms.ComboBox();
            this.cbTheorySubject = new System.Windows.Forms.ComboBox();
            this.cbTheoryGroup = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTheoryAddIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clbAttendence = new System.Windows.Forms.CheckedListBox();
            this.clbCoveredSubjects = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFlightsInstructor = new System.Windows.Forms.ComboBox();
            this.cbFlightsDepartureAirport = new System.Windows.Forms.ComboBox();
            this.cbFlightsAirplane = new System.Windows.Forms.ComboBox();
            this.cbFlightsExercise = new System.Windows.Forms.ComboBox();
            this.cbFlightsArrivalAirport = new System.Windows.Forms.ComboBox();
            this.cbFlightsStudent = new System.Windows.Forms.ComboBox();
            this.cbFlightsGroup = new System.Windows.Forms.ComboBox();
            this.btnFlightInsertFlight = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpTimeOfDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeOfArrival = new System.Windows.Forms.DateTimePicker();
            this.tbFlightsNotice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabTheory.SuspendLayout();
            this.tabFlights.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTheory);
            this.tabControl1.Controls.Add(this.tabFlights);
            this.tabControl1.Controls.Add(this.tabFinance);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 884);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTheory
            // 
            this.tabTheory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTheory.Controls.Add(this.groupBox1);
            this.tabTheory.Location = new System.Drawing.Point(4, 29);
            this.tabTheory.Name = "tabTheory";
            this.tabTheory.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheory.Size = new System.Drawing.Size(1219, 851);
            this.tabTheory.TabIndex = 0;
            this.tabTheory.Text = "Theory";
            this.tabTheory.UseVisualStyleBackColor = true;
            // 
            // tabFlights
            // 
            this.tabFlights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabFlights.Controls.Add(this.groupBox2);
            this.tabFlights.Location = new System.Drawing.Point(4, 29);
            this.tabFlights.Name = "tabFlights";
            this.tabFlights.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlights.Size = new System.Drawing.Size(1219, 851);
            this.tabFlights.TabIndex = 1;
            this.tabFlights.Text = "Flights";
            this.tabFlights.UseVisualStyleBackColor = true;
            // 
            // tabFinance
            // 
            this.tabFinance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabFinance.Location = new System.Drawing.Point(4, 29);
            this.tabFinance.Name = "tabFinance";
            this.tabFinance.Size = new System.Drawing.Size(1219, 851);
            this.tabFinance.TabIndex = 2;
            this.tabFinance.Text = "Finance";
            this.tabFinance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.clbCoveredSubjects);
            this.groupBox1.Controls.Add(this.clbAttendence);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTheoryAddIn);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbTheoryGroup);
            this.groupBox1.Controls.Add(this.cbTheorySubject);
            this.groupBox1.Controls.Add(this.cbTheoryTeacher);
            this.groupBox1.Location = new System.Drawing.Point(205, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 595);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theory";
            // 
            // cbTheoryTeacher
            // 
            this.cbTheoryTeacher.FormattingEnabled = true;
            this.cbTheoryTeacher.Location = new System.Drawing.Point(66, 71);
            this.cbTheoryTeacher.Name = "cbTheoryTeacher";
            this.cbTheoryTeacher.Size = new System.Drawing.Size(242, 28);
            this.cbTheoryTeacher.TabIndex = 0;
            // 
            // cbTheorySubject
            // 
            this.cbTheorySubject.FormattingEnabled = true;
            this.cbTheorySubject.Location = new System.Drawing.Point(66, 207);
            this.cbTheorySubject.Name = "cbTheorySubject";
            this.cbTheorySubject.Size = new System.Drawing.Size(242, 28);
            this.cbTheorySubject.TabIndex = 1;
            // 
            // cbTheoryGroup
            // 
            this.cbTheoryGroup.FormattingEnabled = true;
            this.cbTheoryGroup.Location = new System.Drawing.Point(66, 142);
            this.cbTheoryGroup.Name = "cbTheoryGroup";
            this.cbTheoryGroup.Size = new System.Drawing.Size(242, 28);
            this.cbTheoryGroup.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnTheoryAddIn
            // 
            this.btnTheoryAddIn.Location = new System.Drawing.Point(66, 338);
            this.btnTheoryAddIn.Name = "btnTheoryAddIn";
            this.btnTheoryAddIn.Size = new System.Drawing.Size(242, 34);
            this.btnTheoryAddIn.TabIndex = 4;
            this.btnTheoryAddIn.Text = "Add In";
            this.btnTheoryAddIn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // clbAttendence
            // 
            this.clbAttendence.FormattingEnabled = true;
            this.clbAttendence.Location = new System.Drawing.Point(351, 71);
            this.clbAttendence.Name = "clbAttendence";
            this.clbAttendence.Size = new System.Drawing.Size(215, 172);
            this.clbAttendence.TabIndex = 9;
            // 
            // clbCoveredSubjects
            // 
            this.clbCoveredSubjects.FormattingEnabled = true;
            this.clbCoveredSubjects.Location = new System.Drawing.Point(351, 293);
            this.clbCoveredSubjects.Name = "clbCoveredSubjects";
            this.clbCoveredSubjects.Size = new System.Drawing.Size(215, 172);
            this.clbCoveredSubjects.TabIndex = 10;
            this.clbCoveredSubjects.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Attendence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Covered Subjects";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tbFlightsNotice);
            this.groupBox2.Controls.Add(this.dtpTimeOfArrival);
            this.groupBox2.Controls.Add(this.dtpTimeOfDeparture);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnFlightInsertFlight);
            this.groupBox2.Controls.Add(this.cbFlightsGroup);
            this.groupBox2.Controls.Add(this.cbFlightsStudent);
            this.groupBox2.Controls.Add(this.cbFlightsArrivalAirport);
            this.groupBox2.Controls.Add(this.cbFlightsExercise);
            this.groupBox2.Controls.Add(this.cbFlightsAirplane);
            this.groupBox2.Controls.Add(this.cbFlightsDepartureAirport);
            this.groupBox2.Controls.Add(this.cbFlightsInstructor);
            this.groupBox2.Location = new System.Drawing.Point(274, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 549);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flights";
            // 
            // cbFlightsInstructor
            // 
            this.cbFlightsInstructor.FormattingEnabled = true;
            this.cbFlightsInstructor.Location = new System.Drawing.Point(54, 103);
            this.cbFlightsInstructor.Name = "cbFlightsInstructor";
            this.cbFlightsInstructor.Size = new System.Drawing.Size(242, 28);
            this.cbFlightsInstructor.TabIndex = 1;
            this.cbFlightsInstructor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbFlightsDepartureAirport
            // 
            this.cbFlightsDepartureAirport.FormattingEnabled = true;
            this.cbFlightsDepartureAirport.Location = new System.Drawing.Point(353, 103);
            this.cbFlightsDepartureAirport.Name = "cbFlightsDepartureAirport";
            this.cbFlightsDepartureAirport.Size = new System.Drawing.Size(242, 28);
            this.cbFlightsDepartureAirport.TabIndex = 2;
            // 
            // cbFlightsAirplane
            // 
            this.cbFlightsAirplane.FormattingEnabled = true;
            this.cbFlightsAirplane.Location = new System.Drawing.Point(54, 333);
            this.cbFlightsAirplane.Name = "cbFlightsAirplane";
            this.cbFlightsAirplane.Size = new System.Drawing.Size(242, 28);
            this.cbFlightsAirplane.TabIndex = 3;
            // 
            // cbFlightsExercise
            // 
            this.cbFlightsExercise.FormattingEnabled = true;
            this.cbFlightsExercise.Location = new System.Drawing.Point(54, 279);
            this.cbFlightsExercise.Name = "cbFlightsExercise";
            this.cbFlightsExercise.Size = new System.Drawing.Size(242, 28);
            this.cbFlightsExercise.TabIndex = 4;
            // 
            // cbFlightsArrivalAirport
            // 
            this.cbFlightsArrivalAirport.FormattingEnabled = true;
            this.cbFlightsArrivalAirport.Location = new System.Drawing.Point(353, 160);
            this.cbFlightsArrivalAirport.Name = "cbFlightsArrivalAirport";
            this.cbFlightsArrivalAirport.Size = new System.Drawing.Size(242, 28);
            this.cbFlightsArrivalAirport.TabIndex = 5;
            // 
            // cbFlightsStudent
            // 
            this.cbFlightsStudent.FormattingEnabled = true;
            this.cbFlightsStudent.Location = new System.Drawing.Point(54, 219);
            this.cbFlightsStudent.Name = "cbFlightsStudent";
            this.cbFlightsStudent.Size = new System.Drawing.Size(242, 28);
            this.cbFlightsStudent.TabIndex = 6;
            // 
            // cbFlightsGroup
            // 
            this.cbFlightsGroup.FormattingEnabled = true;
            this.cbFlightsGroup.Location = new System.Drawing.Point(54, 160);
            this.cbFlightsGroup.Name = "cbFlightsGroup";
            this.cbFlightsGroup.Size = new System.Drawing.Size(242, 28);
            this.cbFlightsGroup.TabIndex = 7;
            // 
            // btnFlightInsertFlight
            // 
            this.btnFlightInsertFlight.Location = new System.Drawing.Point(54, 398);
            this.btnFlightInsertFlight.Name = "btnFlightInsertFlight";
            this.btnFlightInsertFlight.Size = new System.Drawing.Size(242, 35);
            this.btnFlightInsertFlight.TabIndex = 8;
            this.btnFlightInsertFlight.Text = "Insert Flight";
            this.btnFlightInsertFlight.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Instructor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Arrival Airport";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Departure Airport";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Airplane";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Exercise";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Student";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Group";
            // 
            // dtpTimeOfDeparture
            // 
            this.dtpTimeOfDeparture.Location = new System.Drawing.Point(353, 220);
            this.dtpTimeOfDeparture.Name = "dtpTimeOfDeparture";
            this.dtpTimeOfDeparture.Size = new System.Drawing.Size(242, 26);
            this.dtpTimeOfDeparture.TabIndex = 16;
            // 
            // dtpTimeOfArrival
            // 
            this.dtpTimeOfArrival.Location = new System.Drawing.Point(353, 281);
            this.dtpTimeOfArrival.Name = "dtpTimeOfArrival";
            this.dtpTimeOfArrival.Size = new System.Drawing.Size(242, 26);
            this.dtpTimeOfArrival.TabIndex = 17;
            // 
            // tbFlightsNotice
            // 
            this.tbFlightsNotice.Location = new System.Drawing.Point(353, 334);
            this.tbFlightsNotice.Multiline = true;
            this.tbFlightsNotice.Name = "tbFlightsNotice";
            this.tbFlightsNotice.Size = new System.Drawing.Size(242, 99);
            this.tbFlightsNotice.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(349, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Time of Departure";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(349, 256);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Time of Arrival";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(349, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Notice";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 909);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.ShowIcon = false;
            this.Text = "Input Form";
            this.tabControl1.ResumeLayout(false);
            this.tabTheory.ResumeLayout(false);
            this.tabFlights.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTheory;
        private System.Windows.Forms.TabPage tabFlights;
        private System.Windows.Forms.TabPage tabFinance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbCoveredSubjects;
        private System.Windows.Forms.CheckedListBox clbAttendence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbTheoryGroup;
        private System.Windows.Forms.ComboBox cbTheorySubject;
        private System.Windows.Forms.ComboBox cbTheoryTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTheoryAddIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbFlightsNotice;
        private System.Windows.Forms.DateTimePicker dtpTimeOfArrival;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFlightInsertFlight;
        private System.Windows.Forms.ComboBox cbFlightsGroup;
        private System.Windows.Forms.ComboBox cbFlightsStudent;
        private System.Windows.Forms.ComboBox cbFlightsArrivalAirport;
        private System.Windows.Forms.ComboBox cbFlightsExercise;
        private System.Windows.Forms.ComboBox cbFlightsAirplane;
        private System.Windows.Forms.ComboBox cbFlightsDepartureAirport;
        private System.Windows.Forms.ComboBox cbFlightsInstructor;
        private System.Windows.Forms.DateTimePicker dtpTimeOfDeparture;
    }
}