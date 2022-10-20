using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class MainForm : Form
    {
        String connectionString = "Data source =Users.db;Version=3";
        SQLiteConnection connection;
        public String user = "anonymous";

        public MainForm(String user)
        {
            InitializeComponent();
            this.user = user;

            if (this.user == "amonymous" || this.user == "")
            {
                label5.Visible = false;
                linkLabel3.Visible = false;
                return;
            } else 
            {
                label5.Text = "Current user: " + this.user;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                label3.Visible = false;
                linkLabel3.Visible = true;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            timer1.Start();
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.user = "anonymous";
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            label3.Visible  = true;
            linkLabel3.Visible = false;
            

            
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = @"assets/Παπει.jpg";
           // pictureBox1.ImageLocation = @"assets/Παπει Εισοδος.jpg";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }

            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }

            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }

            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }

            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }

            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ημερολόγιοΕκδηλώσεωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendar calendar = new Calendar();
            calendar.ShowDialog();
            this.Close();
        }

        private void χρόνιαΠανεπιστήμιοΠειραιώςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Video80 Video80 = new Video80();
            Video80.ShowDialog();
            this.Close();
        }

        private void ημερολογιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }
    }
}
