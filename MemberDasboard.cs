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
    public partial class MemberDasboard : Form
    {
        public MemberDasboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }

        private void MemberDasboard_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewTimeTable viewTimeTable = new ViewTimeTable();
            viewTimeTable.Visible = true;
            Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewDues viewDues = new ViewDues();
            viewDues.Show();
            Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterClass registerClass = new RegisterClass();
            registerClass.Show();
            Visible=false;
        }
    }
}
