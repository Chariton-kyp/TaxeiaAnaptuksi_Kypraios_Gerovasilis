using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class ReviewsForm : Form
    {
        string connectionString = "Data source =Users.db;Version=3;Pooling=true";
        string connectionString2 = "Data source =Reviews.db;Version=3;Pooling=true";
        SQLiteConnection connection;
        SQLiteConnection connection2;
        string user;
        Boolean isUser = false;

        public ReviewsForm(String user)
        {
            InitializeComponent();
            GoFullscreen(true);
            this.user = user;
            if (this.user == "anonymous" || this.user == "")
            {
                button1.Visible = false;
                title.Visible = false;
                body.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
            }
            else
            {
                title.Visible = true;
                body.Visible = true;
                button1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                isUser = true;
            }
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

        private void ReviewsForm_Load(object sender, EventArgs e)
        {

            connection = new SQLiteConnection(connectionString);
            connection2 = new SQLiteConnection(connectionString2);

            ReviewsLoad();
            GoFullscreen(true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string title = this.title.Text;
            string description = this.body.Text;
            int usersId = 0;
            string usersUsername = "";

            try
            {
                string selectSQL = "SELECT * from Users where email='" + this.user + "'";
                SQLiteCommand selectCommand = new SQLiteCommand(selectSQL, connection);
                SQLiteDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    var result = reader.GetString(3);
                    if (result.ToString().Trim() == this.user)
                    {
                        usersId = reader.GetInt32(0);
                        usersUsername = reader.GetString(1);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs. Please try again later!");
            }
            connection.Close();

            connection2.Open();
            try
            {
                string insertSQL = "Insert into Reviews (description,usersId,title) VALUES ('" + description + "','" + usersId + "','" + title + "','" + usersUsername + "')";
                SQLiteCommand cmd = new SQLiteCommand(insertSQL, connection2);
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
            connection2.Close();

            ReviewsLoad();
        }

        private void ReviewsLoad()
        {
            connection2.Open();

            try
            {
                string selectSQL = "SELECT * from Reviews";
                SQLiteCommand selectCommand = new SQLiteCommand(selectSQL, connection2);
                SQLiteDataReader reader = selectCommand.ExecuteReader();

                int counter = 0;
                if (isUser)
                {
                    counter = 1;
                }

                while (reader.Read())
                {
                    var titleToShow = new TextBox();
                    titleToShow.Location = new System.Drawing.Point(350, 147 + counter * 170);
                    titleToShow.Name = "title" + counter;
                    titleToShow.Size = new System.Drawing.Size(771, 20);
                    titleToShow.TabIndex = 2 + counter;
                    titleToShow.Text = reader.GetString(1);
                    this.Controls.Add(titleToShow);
                    titleToShow.ReadOnly = true;


                    var bodyToShow = new RichTextBox();
                    bodyToShow.Location = new System.Drawing.Point(350, 198 + counter * 170);
                    bodyToShow.Name = "title" + counter;
                    bodyToShow.Size = new System.Drawing.Size(771, 72);
                    bodyToShow.TabIndex = 6 + counter;
                    bodyToShow.Text = reader.GetString(3);
                    this.Controls.Add(bodyToShow);
                    bodyToShow.ReadOnly = true;

                    var userName = new Label();
                    userName.AutoSize = true;
                    userName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
                    userName.Location = new System.Drawing.Point(50, 125 + counter * 170);
                    userName.Name = "label00" + counter;
                    userName.Size = new System.Drawing.Size(38, 19);
                    userName.TabIndex = 7 + counter;
                    userName.Text = "user " + reader.GetString(4) + " wrote:";
                    this.Controls.Add(userName);



                    var titleShowing = new Label();
                    titleShowing.AutoSize = true;
                    titleShowing.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
                    titleShowing.Location = new System.Drawing.Point(350, 125 + counter * 170);
                    titleShowing.Name = "label0" + counter;
                    titleShowing.Size = new System.Drawing.Size(38, 19);
                    titleShowing.TabIndex = 4 + counter;
                    titleShowing.Text = "Title";
                    this.Controls.Add(titleShowing);

                    var bodyShowing = new Label();
                    bodyShowing.AutoSize = true;
                    bodyShowing.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
                    bodyShowing.Location = new System.Drawing.Point(350, 176 + counter * 170);
                    bodyShowing.Name = "label0" + counter;
                    bodyShowing.Size = new System.Drawing.Size(41, 19);
                    bodyShowing.TabIndex = 7 + counter;
                    bodyShowing.Text = "Body";
                    this.Controls.Add(bodyShowing);

                    counter += 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs. Please try again later!");
            }

            connection2.Close();
        }
    }
}
