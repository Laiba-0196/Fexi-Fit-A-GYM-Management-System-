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

namespace Fexi_Fit_Project
{
    public partial class Add_Train : Form
    {
        public Trainer trainerinfo { get; set; }
        public Add_Train()
        {
            InitializeComponent();
        }

        private void Add_Train_Load(object sender, EventArgs e)
        {
            if (trainerinfo != null)
            {
                // Assuming comboBox1, comboBox2, and comboBox3 are your ComboBox controls
                comboBox1.SelectedItem = trainerinfo.classtype;
                comboBox2.SelectedItem = trainerinfo.classtiming;
                comboBox3.SelectedItem = trainerinfo.Gender;

                ////// Assuming dateTimePicker1 and dateTimePicker2 are your DateTimePicker controls
                //dateTimePicker1.Value = DateTime.Parse(memberinfo.JoiningDate);
                //dateTimePicker2.Value = DateTime.Parse(memberinfo.DOB);

                // Assuming memberinfo.JoiningDate is the existing DateTime value you want to load
                //DateTime existingJoiningDate = DateTime.Parse(memberinfo.JoiningDate);
                //dateTimePicker1.Value = existingJoiningDate;
                //DateTime existingDOB = DateTime.Parse(memberinfo.DOB);
                //dateTimePicker2.Value = existingDOB;


                // Updating other member info
                trainerinfo.FirstName = trainerinfo.FirstName;
                trainerinfo.LastName = trainerinfo.LastName;
                trainerinfo.PhoneNumber = trainerinfo.PhoneNumber;
                trainerinfo.Email = trainerinfo.Email;



            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Add_Train add_Train = new Add_Train();
            add_Train.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            //textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1; // Resetting the selected index of the ComboBox
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now; // Resetting the DateTimePicker to current date and time
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime selectedDate = dateTimePicker2.Value;
            trainerinfo.DOB = selectedDate.ToString("yyyy-MM-dd");
            DateTime selectdata = dateTimePicker1.Value;
            trainerinfo.JoiningDate = selectedDate.ToString("yyyy-MM-dd");
            trainerinfo.FirstName = textBox1.Text;
            trainerinfo.LastName = textBox2.Text;
            trainerinfo.PhoneNumber = textBox3.Text;
            trainerinfo.Email = textBox5.Text;
            //memberinfo.classtype = textBox1.Text;
            //classtiming
            // gender
            trainerinfo.ID = textBox4.Text;
            string selectedClassType = comboBox1.SelectedItem.ToString();
            trainerinfo.classtype = selectedClassType;
            String selectedgender = comboBox3.SelectedItem.ToString();
            trainerinfo.Gender = selectedgender;
            String selectedTiming = comboBox2.SelectedItem.ToString();
            trainerinfo.classtiming = selectedTiming;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
