using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    public partial class Video80 : Form
    {
        public Video80()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content= 'IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' scr='https://www.youtube.com/embed/{0}' wiht='500' height='250' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            this.webVideo.DocumentText = string.Format(html, txtVideoLink.Text.Split('='));
        }

        private void webVideo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
