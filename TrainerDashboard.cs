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
    public partial class TrainerDashboard : Form
    {
        public TrainerDashboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
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
    }
}
