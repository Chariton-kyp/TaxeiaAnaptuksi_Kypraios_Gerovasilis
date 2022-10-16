using System;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class ReviewsForm : Form
    {
        String user;
        public ReviewsForm(String user)
        {
            InitializeComponent();
            this.user = user;
            if (this.user == "anonymous" || this.user == "")
            {
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TextBox title = new TextBox();
            RichTextBox body = new RichTextBox();
            title.Show();
            title.Visible = true;
            body.Visible = true;
        }
    }
}
