﻿using System;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class OdeProfessors : Form
    {
        public OdeProfessors()
        {
            InitializeComponent();
        }

        private void OdeProfessors_Load(object sender, EventArgs e)
        {
            this.OdeDataGrid.Rows.Add("Αρτίκης Παναγιώτης", "Καθηγητής", "411/ΚΕΚΤ", "+30 210 4142200", "partikis@unipi.gr");
            this.OdeDataGrid.Rows.Add("Γεωργακέλλος Δημήτριος", "Καθηγητής", "402/ΚΕΚΤ", "+30 210 4142252", "dgeorg@unipi.gr");
            this.OdeDataGrid.Rows.Add("Γεωργόπουλος Νικόλαος", "Καθηγητής", "438/ΚΕΚΤ", "+30 210 4142258", "ngeorgop@unipi.gr");
            this.OdeDataGrid.Rows.Add("Σφακιανάκης Μιχαήλ", "Καθηγητής", "404/ΚΕΚΤ", "+30 210 4142398", "msfakian@unipi.gr");
            this.OdeDataGrid.Rows.Add("Φίλιππας Νικόλαος", "Καθηγητής", "323/ΚΕΚΤ", "+30 210 4142168", "philipas@unipi.gr");
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
            for (int i = 1; i < OdeDataGrid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = OdeDataGrid.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < OdeDataGrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < OdeDataGrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = OdeDataGrid.Rows[i].Cells[j].Value.ToString();
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
    }
}