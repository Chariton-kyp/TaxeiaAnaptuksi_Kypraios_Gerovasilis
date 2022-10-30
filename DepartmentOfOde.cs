using System;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class DepartmentOfOde : Form
    {
        string user;
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

        public DepartmentOfOde(String user)
        {
            InitializeComponent();
            GoFullscreen(true);
            this.user = user;
            if (this.user == "anonymous" || this.user == "")
            { }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentOfOde_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"Assets\Images\ode.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
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
    }
}
