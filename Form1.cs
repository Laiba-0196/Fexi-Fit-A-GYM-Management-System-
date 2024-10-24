namespace Fexi_Fit_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox3.Text == "Admin123")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                Visible = false;
            }
            else if (textBox1.Text == "Trainer" && textBox3.Text == "Trainer123")
            {
                TrainerDashboard trainerDashboard = new TrainerDashboard();
                trainerDashboard.Show();
                Visible = false;
            }
            else if (textBox1.Text == "Member" && textBox3.Text == "Member123")
            {
                MemberDasboard memberDasboard = new MemberDasboard();
                memberDasboard.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(90, 255, 255, 255);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //BackColor=Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}