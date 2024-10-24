using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Fexi_Fit_Project
{
    public partial class Timetable : Form
    {
        public string Date { get; }
        public string ClassTiming { get; } // Changed from "classtiming" to "ClassTiming"
        public string TrainerName { get; }
        public string ClassRoom { get; }
        public string ClassType { get; } // Changed from "classtype" to "ClassType"

        private List<Timetable> timetableSlots;
        public Timetable()
        {
            InitializeComponent();
            timetableSlots = new List<Timetable>();
            //Load timetable data when the form is loaded
            LoadTimetableFromFile();
        }
        private void LoadTimetableFromFile()
        {
            try
            {
                // Read timetable data from the file
                using (StreamReader reader = new StreamReader("timetable.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        string date = data[0];
                        string classTiming = data[1];
                        string classRoom = data[2];
                        string classType = data[3];
                        string trainerName = data[4];

                        Timetable slot = new Timetable(date, classTiming, classRoom, classType, trainerName);
                        timetableSlots.Add(slot);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // If the file doesn't exist, no action needed (load an empty timetable)
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Button1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            Visible = false;
        }

        private void Timetable_load(object sender, EventArgs e)
        {
            LoadTimetableFromFile();
        }

        private void UpdateTimetableDisplay()
        {
            foreach (var slot in timetableSlots)
            {
                DataGridViewRow row = new DataGridViewRow();

                if (datagridview1.Columns.Count >= 5) // Ensure DataGridView has enough columns
                {
                    row.CreateCells(datagridview1);

                    // Set cell values in the desired order
                    row.Cells[0].Value = slot.ClassType;
                    row.Cells[1].Value = slot.TrainerName;
                    row.Cells[2].Value = slot.ClassRoom;
                    row.Cells[3].Value = slot.Date;
                    row.Cells[4].Value = slot.ClassTiming;

                    datagridview1.Rows.Add(row);
                }
                else
                {
                    MessageBox.Show("Not enough columns in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Display the timetable slots in the DataGridView
            //    datagridview1.Rows.Clear(); // Clear existing rows
            //    foreach (var slot in timetableSlots)
            //    {
            //        // datagridview1.Rows.Add( slot.ClassType, slot.TrainerName, slot.ClassRoom, slot.Date, slot.ClassTiming);
            //        DataGridViewRow row = new DataGridViewRow();
            //        row.CreateCells(datagridview1);

            //        // Set cell values in the desired order
            //        row.Cells[0].Value = slot.ClassType;
            //        row.Cells[1].Value = slot.TrainerName;
            //        row.Cells[2].Value = slot.ClassRoom;
            //        row.Cells[3].Value = slot.Date;
            //        row.Cells[4].Value = slot.ClassTiming;

            //        datagridview1.Rows.Add(row);
            //    }
        }
        private void SaveTimetableToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("timetable.txt"))
                {
                    foreach (var slot in timetableSlots)
                    {
                        writer.WriteLine($"{slot.Date},{slot.ClassTiming},{slot.ClassRoom},{slot.ClassType},{slot.TrainerName}");
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error saving timetable data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputFields()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

        }
        //private void DisplayTimetable()
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {

            string date = dateTimePicker1.Text;
            string classTiming = comboBox4.Text;
            string classRoom = comboBox3.Text;
            string classType = comboBox1.Text;
            string trainerName = comboBox2.Text;

            Timetable slot = new Timetable(date, classTiming, classRoom, classType, trainerName);
            timetableSlots.Add(slot);

            ClearInputFields();
            UpdateTimetableDisplay(); // Update the display
            SaveTimetableToFile();
        }
        public Timetable(string date, string classTiming, string trainerName, string classRoom, string classType)
        {
            Date = date;
            ClassTiming = classTiming;
            TrainerName = trainerName;
            ClassRoom = classRoom;
            ClassType = classType;
        }

        public override string ToString()
        {
            return $"{Date} - {ClassTiming} : {ClassType} ({TrainerName})";
        }
    }

}
