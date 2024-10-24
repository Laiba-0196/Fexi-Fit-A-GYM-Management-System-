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
    public partial class Viewfeedback : Form
    {
        public Viewfeedback()
        {
            InitializeComponent();
        }

        private void Viewfeedback_Load(object sender, EventArgs e)
        {
            // Retrieve feedback entries from the FeedbackSystem
            string[] feedbackEntries = FeedbackSystem.GetFeedbackEntries();

            // Clear any existing feedback entries from the display
            textBox1.Clear();

            // Display feedback entries in a text box
            foreach (string entry in feedbackEntries)
            {
                textBox1.AppendText(entry + Environment.NewLine);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            Visible = false;
        }
    }
}
