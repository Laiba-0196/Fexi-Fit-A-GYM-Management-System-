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
    public partial class TrainerPanel : Form
    {
        public TrainerPanel()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Add_Train Addtrain = new Add_Train() { trainerinfo = new Trainer() })
            {
                if (Addtrain.ShowDialog() == DialogResult.OK)
                    trainerBindingSource.Add(Addtrain.trainerinfo);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trainer obj = trainerBindingSource.Current as Trainer;
            if (obj != null)
            {
                using (Add_Train Addmam = new Add_Train() { trainerinfo = obj })
                    if (Addmam.ShowDialog() == DialogResult.OK)
                    {
                        trainerBindingSource.EndEdit();
                        button2.Focus();
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);
        }
    }


}
