using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Fexi_Fit_Project
{
    public partial class ViewTimeTable : Form
    {
        private List<Timetable> timetableSlots;
        public ViewTimeTable()
        {
            InitializeComponent();
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

                        // Add the timetable data to DataGridView
                        datagridview1.Rows.Add(date, classTiming, classRoom, classType, trainerName);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Timetable file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error reading timetable data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void ViewTimeTable_Load(object sender, EventArgs e)
        {

            LoadTimetableFromFile();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MemberDasboard memberDasboard = new MemberDasboard();
            memberDasboard.Show();
            Visible = false;
        }
    }
}
