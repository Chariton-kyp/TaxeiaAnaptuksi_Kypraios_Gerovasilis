using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class Register : Form
    {
        string user;
        String connectionString = "Data source =Users.db;Version=3;Pooling=true";
        SQLiteConnection connection;

        public Register(String user)
        {
            InitializeComponent();
            GoFullscreen(true);
            this.user = user;
            if (this.user == "anonymous" || this.user == "")
            { }
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            GoFullscreen(true);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            connection.Open();
            String email = textBox1.Text;
            String password = textBox2.Text;
            String firstName = textBox3.Text;
            String lastName = textBox4.Text;

            try
            {
                String selectSQL = "SELECT * from Users where email='" + email + "'";
                SQLiteCommand selectCommand = new SQLiteCommand(selectSQL, connection);
                SQLiteDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    var result = reader.GetString(3);
                    if (result.ToString().Trim() == email)
                    {
                        MessageBox.Show("The email " + email + " you used, already exists!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs. Please try again later!");
            }

            try
            {
                String insertSQL = "Insert into Users(email,password,firstName,lastName) " +
                "values('" + email + "','" + password + "','" + firstName + "','" + lastName + "')";
                SQLiteCommand cmd = new SQLiteCommand(insertSQL, connection);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Successfully registered");
                    this.Hide();
                    MainForm mainForm = new MainForm("");
                    mainForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs. Please try again later!");
            }

            connection.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm(user);
            mainform.ShowDialog();
            this.Close();
        }

        private void reviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewsForm reviewsForm = new ReviewsForm(this.user);
            reviewsForm.ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Video video = new Video(user);
            video.ShowDialog();
            this.Close();
        }

        private void εκδηλώσειςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalendarEvents calendarEvents = new CalendarEvents(this.user);
            calendarEvents.ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutForm about = new AboutForm(user);
            about.ShowDialog();
            this.Close();
        }

        private void τμήμαΠληροφορικήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentOfInformartics departmentOfInformartics = new DepartmentOfInformartics(this.user);
            departmentOfInformartics.ShowDialog();
            this.Close();
        }

        private void τμήμαΟΔΕToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentOfOde departmentOfOde = new DepartmentOfOde(this.user);
            departmentOfOde.ShowDialog();
            this.Close();
        }

        private void τμήμαΟικονομικώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentOfFinancials departmentOfFinancials = new DepartmentOfFinancials(this.user);
            departmentOfFinancials.ShowDialog();
            this.Close();
        }

        private void καθηγητέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformaticsProfessors informaticsProfessors = new InformaticsProfessors(this.user);
            informaticsProfessors.ShowDialog();
            this.Close();
        }

        private void καθηγητέςToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdeProfessors odeProfessors = new OdeProfessors(this.user);
            odeProfessors.ShowDialog();
            this.Close();
        }

        private void καθηγητέςToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinancialProfessors financialProfessors = new FinancialProfessors(this.user);
            financialProfessors.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
