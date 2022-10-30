using System;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class InformaticsProfessors : Form
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
        public InformaticsProfessors(String user)
        {
            InitializeComponent();
            GoFullscreen(true);
            this.user = user;
            if (this.user == "anonymous" || this.user == "")
            { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InformaticsProfessors_Load(object sender, EventArgs e)
        {
            this.InformaticsDataGrid.Rows.Add("Αποστόλου Δημήτριος", "Καθηγητής", "303/ΓΛ126", "+30 210 4142476", "dapost@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Βέργαδος Δημήτριος", "Καθηγητής", "104/ΓΛ126", "+30 210 4142479", "vergados@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Βίρβου Μαρία", "Καθηγητής", "507/ΚΕΚΤ", "+30 210 4142269", "mvirvou@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Δουληγέρης Χρήστος", "Καθηγητής", "302/ΚΕΚΤ", "+30 210 4142137", "cdoulig@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Θεοδωρίδης Ιωάννης", "Καθηγητής", "501/ΚΕΚΤ", "+30 210 4142449", "ytheod@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Κωνσταντόπουλος Χαράλαμπος", "Καθηγητής", "104/ΓΛ126", "+30 210 4142124", "konstant@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Μεταξιώτης Κωνσταντίνος", "Καθηγητής", "303/ΓΛ126", "+30 210 4142578", "kmetax@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Παναγιωτόπουλος Θεμιστοκλής", "Καθηγητής", "541/ΚΕΚΤ", "+30 210 4142146", "themisp@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Πολέμη Δέσποινα", "Καθηγητής", "502/ΚΕΚΤ", "+30 210 4142270", "dpolemi@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Τσιχριντζής Γεώργιος", "Καθηγητής", "506/ΚΕΚΤ", "+30 210 4142322", "geoatsi@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Αλέπης Ευθύμιος", "Αναπληρωτής Καθηγητής", "540/ΚΕΚΤ", "+30 210 4142311", "talepis@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Βουγιουκλίδου Άννα", "Αναπληρωτής Καθηγητής", "4ος/ΖΕΑΣ", "+30 210 4142407", "avou@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Κοτζανικολάου Παναγιώτης", "Αναπληρωτής Καθηγητής", "302/ΓΛ126", "+30 210 4142261", "pkotzani@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Πατσάκης Κωνσταντίνος", "Αναπληρωτής Καθηγητής", "540/ΚΕΚΤ", "+30 210 4142312", "kpatsak@unipi.gr");
            this.InformaticsDataGrid.Rows.Add("Σακκόπουλος Ευάγγελος", "Αναπληρωτής Καθηγητής", "543/ΚΕΚΤ", "+30 210 4142425", "sakkopul@unipi.gr");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workingbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workingbook.Sheets["Sheet1"];
            worksheet = workingbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < InformaticsDataGrid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = InformaticsDataGrid.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < InformaticsDataGrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < InformaticsDataGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = InformaticsDataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            try
            {

                // save the application  
                workingbook.SaveCopyAs("InformaticsDataGrid.xlsx");
                // Exit from the application  
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
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
