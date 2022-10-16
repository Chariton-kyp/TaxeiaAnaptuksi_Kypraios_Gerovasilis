using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class Login : Form
    {
        String connectionString = "Data source =Users.db;Version=3;Pooling=true";
        SQLiteConnection connection;
        string anonymous = "Visitor";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String email = textBox1.Text;
            String password = textBox2.Text;

            String selectSQL = "SELECT * from Users where email='" + email + "' AND password='" + password + "'";
            SQLiteCommand selectCommand = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = selectCommand.ExecuteReader();

            var counter = 0;
            while (reader.Read())
            {
                var readEmail = reader.GetString(3);
                var readPassword = reader.GetString(4);
                if (readEmail.ToString().Trim() == email && readPassword.ToString().Trim() == password)
                {
                    MessageBox.Show("Welcome " + reader.GetString(1));
                    this.Hide();
                    MainForm mainForm = new MainForm(reader.GetString(3));
                    mainForm.ShowDialog();
                    this.Close();
                }
                counter++;
            }

            if (counter == 0)
            {
                MessageBox.Show("Incorrect Email or Password! Try again!");
            }

            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(anonymous);
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
