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
    public partial class ViewDues : Form
    {
        private const string DuesReceiptsFilePath = "dues_receipts.txt";
        public ViewDues()
        {
            InitializeComponent();
            LoadDuesReceipts();
        }

        private void ViewDues_Load(object sender, EventArgs e)
        {

        }
        private void LoadDuesReceipts()
        {
            try
            {
                using (StreamReader reader = new StreamReader(DuesReceiptsFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(',');

                        string memberName = parts[0];
                        decimal amount = decimal.Parse(parts[1]);
                        DateTime issuedate = DateTime.Parse(parts[2]);
                        DateTime duedate = DateTime.Parse(parts[3]);
                        decimal amountafterduedate = decimal.Parse(parts[4]);
                        string receiptNumber = parts[5];

                        // Display dues receipt details in a suitable way
                        // For example, you can add them to a DataGridView
                        dataGridView1.Rows.Add(memberName, amount, issuedate, duedate, amountafterduedate, receiptNumber);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Dues receipts file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error reading dues receipts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error parsing dues receipt data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrainerDashboard trainerDashboard = new TrainerDashboard();
             trainerDashboard.Show();
            Visible = false;
            MemberDasboard memberDasboard=new MemberDasboard();
            memberDasboard.Show();
            Visible = false;
        }
    }
}

