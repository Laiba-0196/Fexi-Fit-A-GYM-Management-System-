using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fexi_Fit_Project
{
    public partial class RegisterClass : Form
    {
        public RegisterClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Successfully");
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
            // dateTimePicker1.Value = DateTime.Now; // Resetting the DateTimePicker to current date and time
            dateTimePicker2.Value = DateTime.Now;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MemberDasboard memberDasboard = new MemberDasboard();
            memberDasboard.Show();
            Visible = false;
        }
    }
}
