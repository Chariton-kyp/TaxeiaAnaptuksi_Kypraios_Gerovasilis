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
            MainForm mainform = new MainForm(user);
            mainform.ShowDialog();
            this.Close();
            
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

        private void σχολέςToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutForm about = new AboutForm(user);
            about.ShowDialog();
            this.Close();
        }
    }
}
