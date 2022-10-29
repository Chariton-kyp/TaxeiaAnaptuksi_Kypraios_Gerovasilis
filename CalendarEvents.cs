using System;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class CalendarEvents : Form
    {
        //private string anoynmous;
        string user;

        public CalendarEvents(string user)
        {
            InitializeComponent();
            GoFullscreen(true);
            this.user = user;
            if (this.user == "anonymous" || this.user == "")
            { }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Αρχή Ακαδημαϊκής Χρονιάς");
        }

        private void label39_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Παρουσίαση Μαθημάτων Μεταπτυχιακού Πληροφορικής");
        }

        private void label40_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επέτειος του Πολυτεχνείου");
        }

        private void label41_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουρνουά Ποδοσφαίρου");
        }

        private void label42_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πανελλήνιο Συνέδριο Πληροφορικής");
        }

        private void label43_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουρνουά Σκάκι");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm("");
            mainform.ShowDialog();
            this.Close();
            // Αποσυνδέεται ο χρήστης όταν γυρίζει στην αρχική
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

        private void CalendarEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
