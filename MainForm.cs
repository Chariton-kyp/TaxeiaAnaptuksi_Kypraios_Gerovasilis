using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class MainForm : Form
    {
        String connectionString = "Data source =Users.db;Version=3;Pooling=true";
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
            }
            else
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
            label3.Visible = true;
            linkLabel3.Visible = false;
            label5.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void reviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewsForm reviewsForm = new ReviewsForm(this.user);
            reviewsForm.ShowDialog();
            this.Close();
        }
    }
}
