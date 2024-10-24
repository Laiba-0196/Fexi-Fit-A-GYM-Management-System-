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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    string name = textBox2.Text;
            //    string email = textBox1.Text;

            //    string message = textBox3.Text;

            //    // Call the SubmitFeedback method from the FeedbackSystem class
            //    FeedbackSystem.SubmitFeedback(name, email, message);

            //    // Optionally, you can display a message to the user after submitting feedback
            //    MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Clear the input fields after submitting feedback
            //    textBox1.Text = "";
            //    textBox2.Text = "";
            //    //typeTextBox.Text = "";
            //    textBox3.Text = "";
            string name = textBox2.Text;
            string email = textBox1.Text;
            string message = textBox3.Text;

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Feedback cannot be empty. Please provide your feedback before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Call the SubmitFeedback method from the FeedbackSystem class
                FeedbackSystem.SubmitFeedback(name, email, message);

                // Optionally, you can display a message to the user after submitting feedback
                MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields after submitting feedback
                textBox1.Text = "";
                textBox2.Text = "";
                //typeTextBox.Text = "";
                textBox3.Text = "";
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MemberDasboard memberDasboard = new MemberDasboard();
            memberDasboard.Show();
            Visible = false;
        }
    }
}
