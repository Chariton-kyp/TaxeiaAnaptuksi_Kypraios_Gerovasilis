using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class ReviewsForm : Form
    {
        String connectionString = "Data source =Users.db;Version=3";
        SQLiteConnection connection;
        String user;
        public ReviewsForm(String user)
        {
            InitializeComponent();
            this.user = user;
            if (this.user == "anonymous" || this.user == "")
            {
                button1.Visible = false;
                title.Visible = false;
                body.Visible = false;
            }
            else
            {
                title.Visible = true;
                body.Visible = true;
                button1.Visible = true;
            }
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String title = this.title.Text;
            String description = this.body.Text;
            int usersId = 0;

            try
            {
                String selectSQL = "SELECT * from Users where email='" + this.user + "'";
                SQLiteCommand selectCommand = new SQLiteCommand(selectSQL, connection);
                SQLiteDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    var result = reader.GetString(3);
                    if (result.ToString().Trim() == this.user)
                    {
                        usersId = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs. Please try again later!");
            }

            try
            {
                String insertSQL = "Insert into Reviews(description,usersId,title) " +
                "values('" + description + "','" + usersId + "','" + title + "')";
                SQLiteCommand cmd = new SQLiteCommand(insertSQL, connection);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Successfully posted your review");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs. Please try again later!");
            }

            connection.Close();


        }


    }
}
