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
    public partial class CalendarEvents : Form
    {
        //private string anoynmous;

        public CalendarEvents(string user)
        {
            InitializeComponent();
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
    }
}
