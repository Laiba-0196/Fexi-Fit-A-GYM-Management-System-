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
    public partial class AdminDashboard : Form
    {
        // public time timetable{ get; set; }
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MemberPanel memberPanel = new MemberPanel();
            memberPanel.Show();
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TrainerPanel trainerPanel = new TrainerPanel();
            trainerPanel.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Timetable timetable = new Timetable();
            timetable.Show();
            Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Viewfeedback viewfeedback = new Viewfeedback();
            viewfeedback.Show();
            Visible = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DuesReceipt receipt = new DuesReceipt();
            receipt.Show();
            Visible = false;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            Form1 form1
                = new Form1();
            form1.Show();
            Visible = false;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Viewfeedback viewfeedback1 = new Viewfeedback();
            viewfeedback1.Show();
            Visible=false;
        }
    }
}
