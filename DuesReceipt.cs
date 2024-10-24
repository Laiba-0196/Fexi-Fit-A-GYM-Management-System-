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
    public partial class DuesReceipt : Form
    {
        private const string DuesReceiptsFilePath = "dues_receipts.txt";
        public DuesReceipt()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get dues receipt details from form inputs
            string memberName = textBox1.Text;
            decimal amount = decimal.Parse(textBox3.Text);

            DateTime issuedate = dateTimePicker1.Value;
            DateTime duedate = dateTimePicker2.Value;
            decimal amountafterduedate = decimal.Parse(textBox5.Text);
            string receiptNumber = textBox6.Text;

            // Create dues receipt string
            string duesReceipt = $"{memberName},{amount},{issuedate},{duedate},{amountafterduedate},{receiptNumber}";

            // Save dues receipt to file
            try
            {
                using (StreamWriter writer = new StreamWriter(DuesReceiptsFilePath, true))
                {
                    writer.WriteLine(duesReceipt);
                }

                MessageBox.Show("Dues receipt saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving dues receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
