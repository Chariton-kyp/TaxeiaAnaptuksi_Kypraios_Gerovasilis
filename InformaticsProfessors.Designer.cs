namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    partial class InformaticsProfessors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.InformaticsDataGrid = new System.Windows.Forms.DataGridView();
            this.Καθηγητές = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ιδιότητα = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Γραφείο = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Τηλέφωνο = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel36 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InformaticsDataGrid)).BeginInit();
            this.panel36.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(620, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Καθηγητές Τμήματος Πληροφορικής";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InformaticsDataGrid
            // 
            this.InformaticsDataGrid.AllowUserToAddRows = false;
            this.InformaticsDataGrid.AllowUserToDeleteRows = false;
            this.InformaticsDataGrid.AllowUserToOrderColumns = true;
            this.InformaticsDataGrid.AllowUserToResizeRows = false;
            this.InformaticsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.InformaticsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InformaticsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InformaticsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Καθηγητές,
            this.Ιδιότητα,
            this.Γραφείο,
            this.Τηλέφωνο,
            this.Email});
            this.InformaticsDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.InformaticsDataGrid.Location = new System.Drawing.Point(352, 185);
            this.InformaticsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.InformaticsDataGrid.Name = "InformaticsDataGrid";
            this.InformaticsDataGrid.Size = new System.Drawing.Size(954, 366);
            this.InformaticsDataGrid.TabIndex = 3;
            this.InformaticsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Καθηγητές
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Καθηγητές.DefaultCellStyle = dataGridViewCellStyle6;
            this.Καθηγητές.HeaderText = "Καθηγητές";
            this.Καθηγητές.Name = "Καθηγητές";
            this.Καθηγητές.ReadOnly = true;
            this.Καθηγητές.Width = 200;
            // 
            // Ιδιότητα
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Ιδιότητα.DefaultCellStyle = dataGridViewCellStyle7;
            this.Ιδιότητα.HeaderText = "Ιδιότητα";
            this.Ιδιότητα.Name = "Ιδιότητα";
            this.Ιδιότητα.ReadOnly = true;
            this.Ιδιότητα.Width = 170;
            // 
            // Γραφείο
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Γραφείο.DefaultCellStyle = dataGridViewCellStyle8;
            this.Γραφείο.HeaderText = "Γραφείο";
            this.Γραφείο.Name = "Γραφείο";
            this.Γραφείο.ReadOnly = true;
            this.Γραφείο.Width = 170;
            // 
            // Τηλέφωνο
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Τηλέφωνο.DefaultCellStyle = dataGridViewCellStyle9;
            this.Τηλέφωνο.HeaderText = "Τηλέφωνο";
            this.Τηλέφωνο.Name = "Τηλέφωνο";
            this.Τηλέφωνο.ReadOnly = true;
            this.Τηλέφωνο.Width = 170;
            // 
            // Email
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Email.DefaultCellStyle = dataGridViewCellStyle10;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(352, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Εξαγωγή Δεδομένων";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.panel36.Controls.Add(this.richTextBox2);
            this.panel36.Controls.Add(this.richTextBox3);
            this.panel36.Location = new System.Drawing.Point(2, 723);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(1710, 251);
            this.panel36.TabIndex = 13;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(1172, 23);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(335, 174);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Produced Academic Purposes\n\nUniversity of Piraeus\n\nΤαχεία Ανάπτυξη Εφαρμογών";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(102, 23);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(335, 174);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = " ΣΤΟΙΧΕΙΑ ΕΠΙΚΟΙΝΩΝΙΑΣ\n Διεύθυνση: Μ. Καραολή & Α. Δημητρίου 80, \n18534 Πειραιάς\n" +
    "\n Τηλ. Κέντρο: 210 4142000\n\n Fax: 210 4142328";
            // 
            // InformaticsProfessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 974);
            this.Controls.Add(this.panel36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InformaticsDataGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InformaticsProfessors";
            this.Text = "InformaticsProfessors";
            this.Load += new System.EventHandler(this.InformaticsProfessors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformaticsDataGrid)).EndInit();
            this.panel36.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InformaticsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Καθηγητές;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ιδιότητα;
        private System.Windows.Forms.DataGridViewTextBoxColumn Γραφείο;
        private System.Windows.Forms.DataGridViewTextBoxColumn Τηλέφωνο;
        private System.Windows.Forms.DataGridViewLinkColumn Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}