using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class Register : Form
    {
        String connectionString = "Data source =Users.db;Version=3";
        SQLiteConnection connection;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
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
    }
}
