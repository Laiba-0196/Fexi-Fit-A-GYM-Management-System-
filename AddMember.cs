using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Fexi_Fit_Project
{
    public partial class AddMember : Form
    {
        public Member memberinfo { get; set; }
        public AddMember()
        {
            InitializeComponent();


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if all fields are filled
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text) || comboBox1.SelectedItem == null ||
                    comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
                {
                    throw new Exception("Please fill in all fields.");
                }

                // Validate email format
                if (!IsValidEmail(textBox5.Text))
                {
                    throw new Exception("Please enter a valid email address.");
                }

                // Validate ID format
                if (!IsValidID(textBox4.Text))
                {
                    throw new Exception("Please enter a valid ID (alphanumeric with special characters).");
                }

                // If all validations pass, assign values to memberinfo object
                DateTime selectedDate = dateTimePicker2.Value;
                memberinfo.DOB = selectedDate.ToString("yyyy-MM-dd");
                DateTime selectdata = dateTimePicker1.Value;
                memberinfo.JoiningDate = selectedDate.ToString("yyyy-MM-dd");
                memberinfo.FirstName = textBox1.Text;
                memberinfo.LastName = textBox2.Text;
                memberinfo.PhoneNumber = textBox3.Text;
                memberinfo.Email = textBox5.Text;
                memberinfo.ID = textBox4.Text;
                memberinfo.classtype = comboBox1.SelectedItem.ToString();
                memberinfo.Gender = comboBox3.SelectedItem.ToString();
                memberinfo.classtiming = comboBox2.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Function to validate email format
            bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

            // Function to validate ID format
            bool IsValidID(string id)
            {
                // Add your custom ID validation logic here
                // For example, checking for alphanumeric with special characters
                // You can use regular expressions for this purpose
                // For demonstration, let's say the ID must contain at least one uppercase letter, one lowercase letter, and one special character
                return System.Text.RegularExpressions.Regex.IsMatch(id, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).+$");
            }

            //DateTime selectedDate = dateTimePicker2.Value;
            //memberinfo.DOB = selectedDate.ToString("yyyy-MM-dd");
            //DateTime selectdata = dateTimePicker1.Value;
            //memberinfo.JoiningDate = selectedDate.ToString("yyyy-MM-dd");
            //memberinfo.FirstName = textBox1.Text;
            //memberinfo.LastName = textBox2.Text;
            //memberinfo.PhoneNumber = textBox3.Text;
            //memberinfo.Email = textBox5.Text;
            ////memberinfo.classtype = textBox1.Text;
            ////classtiming
            //// gender
            //memberinfo.ID = textBox4.Text;
            //string selectedClassType = comboBox1.SelectedItem.ToString();
            //memberinfo.classtype = selectedClassType;
            //String selectedgender = comboBox3.SelectedItem.ToString();
            //memberinfo.Gender = selectedgender;
            //String selectedTiming = comboBox2.SelectedItem.ToString();
            //memberinfo.classtiming = selectedTiming;



        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            if (memberinfo != null)
            {
                // Assuming comboBox1, comboBox2, and comboBox3 are your ComboBox controls
                comboBox1.SelectedItem = memberinfo.classtype;
                comboBox2.SelectedItem = memberinfo.classtiming;
                comboBox3.SelectedItem = memberinfo.Gender;

                ////// Assuming dateTimePicker1 and dateTimePicker2 are your DateTimePicker controls
                //dateTimePicker1.Value = DateTime.Parse(memberinfo.JoiningDate);
                //dateTimePicker2.Value = DateTime.Parse(memberinfo.DOB);

                // Assuming memberinfo.JoiningDate is the existing DateTime value you want to load
                //DateTime existingJoiningDate = DateTime.Parse(memberinfo.JoiningDate);
                //dateTimePicker1.Value = existingJoiningDate;
                //DateTime existingDOB = DateTime.Parse(memberinfo.DOB);
                //dateTimePicker2.Value = existingDOB;


                // Updating other member info
                memberinfo.FirstName = memberinfo.FirstName;
                memberinfo.LastName = memberinfo.LastName;
                memberinfo.PhoneNumber = memberinfo.PhoneNumber;
                memberinfo.Email = memberinfo.Email;



            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
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

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
