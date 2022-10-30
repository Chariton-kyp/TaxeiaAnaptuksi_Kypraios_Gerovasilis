using System;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class FinancialProfessors : Form
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
        public FinancialProfessors(String user)
        {
            InitializeComponent();
            GoFullscreen(true);
            this.user = user;
            if (this.user == "anonymous" || this.user == "")
            { }
        }

        private void InformaticsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FinancialProfessors_Load(object sender, EventArgs e)
        {
            this.FinancialsDataGrid.Rows.Add("Αγιακλόγλου Χρήστος", "Καθηγητής", "527/ΚΕΚΤ", "+30 210 4142290", "agiaklis@unipi.gr");
            this.FinancialsDataGrid.Rows.Add("Αργυρού Μιχαήλ", "Καθηγητής", "525/ΚΕΚΤ", "+30 210 4142000", "arghyroum@unipi.gr");
            this.FinancialsDataGrid.Rows.Add("Βοζίκης Αθανάσιος", "Καθηγητής", "524/ΚΕΚΤ", "+30 210 4142280", "avozik@unipi.gr");
            this.FinancialsDataGrid.Rows.Add("Κανάς Άγγελος", "Καθηγητής", "521/ΚΕΚΤ", "+30 210 4142195", "akanas@unipi.gr");
            this.FinancialsDataGrid.Rows.Add("Καρκαλάκος Σωτήριος", "Καθηγητής", "531/ΚΕΚΤ", "+30 210 4142288", "sotkar@unipi.gr");
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
            for (int i = 1; i < FinancialsDataGrid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = FinancialsDataGrid.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < FinancialsDataGrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < FinancialsDataGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = FinancialsDataGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            try
            {

                // save the application  
                workingbook.SaveCopyAs("FinancialsDataGrid.xlsx");
                // Exit from the application  
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void εκδηλώσειςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalendarEvents calendarEvents = new CalendarEvents(this.user);
            calendarEvents.ShowDialog();
            this.Close();
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

        private void καθηγητέςToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdeProfessors odeProfessors = new OdeProfessors(this.user);
            odeProfessors.ShowDialog();
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
