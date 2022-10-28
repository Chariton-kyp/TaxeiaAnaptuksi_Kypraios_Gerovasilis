using System;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class DepartmentOfFinancials : Form
    {
        public DepartmentOfFinancials()
        {
            InitializeComponent();
        }

        private void DepartmentOfFinancials_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"Assets\Images\oikonomiko.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
