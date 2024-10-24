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
    public partial class MemberPanel : Form
    {

        public MemberPanel()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddMember Addmam = new AddMember() { memberinfo = new Member() })
            {
                if (Addmam.ShowDialog() == DialogResult.OK)
                    memberBindingSource.Add(Addmam.memberinfo);
            }

        }

        private void MemberPanel_Load(object sender, EventArgs e)
        {

        }

        private void MemberPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member obj = memberBindingSource.Current as Member;
            if (obj != null)
            {
                using (AddMember Addmam = new AddMember() { memberinfo = obj })
                    if (Addmam.ShowDialog() == DialogResult.OK)
                    {
                        memberBindingSource.EndEdit();
                        button2.Focus();
                    }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);
        }
    }
}
