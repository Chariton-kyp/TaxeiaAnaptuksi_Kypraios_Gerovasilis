using System;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class MenuSitisis : Form
    {
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

        public MenuSitisis()
        {
            InitializeComponent();
            GoFullscreen(true);
        }

        private void MenuSitisis_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm("");
            mainform.ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
