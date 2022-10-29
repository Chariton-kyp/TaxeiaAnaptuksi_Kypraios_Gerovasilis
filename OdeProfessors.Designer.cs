namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    partial class OdeProfessors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OdeDataGrid = new System.Windows.Forms.DataGridView();
            this.Καθηγητές = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ιδιότητα = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Γραφείο = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Τηλέφωνο = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel36 = new System.Windows.Forms.Panel();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OdeDataGrid)).BeginInit();
            this.panel36.SuspendLayout();
            this.SuspendLayout();
            // 
            // OdeDataGrid
            // 
            this.OdeDataGrid.AllowUserToAddRows = false;
            this.OdeDataGrid.AllowUserToDeleteRows = false;
            this.OdeDataGrid.AllowUserToOrderColumns = true;
            this.OdeDataGrid.AllowUserToResizeRows = false;
            this.OdeDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OdeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OdeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Καθηγητές,
            this.Ιδιότητα,
            this.Γραφείο,
            this.Τηλέφωνο,
            this.Email});
            this.OdeDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.OdeDataGrid.Location = new System.Drawing.Point(339, 175);
            this.OdeDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.OdeDataGrid.Name = "OdeDataGrid";
            this.OdeDataGrid.Size = new System.Drawing.Size(954, 164);
            this.OdeDataGrid.TabIndex = 5;
            // 
            // Καθηγητές
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Καθηγητές.DefaultCellStyle = dataGridViewCellStyle1;
            this.Καθηγητές.HeaderText = "Καθηγητές";
            this.Καθηγητές.Name = "Καθηγητές";
            this.Καθηγητές.ReadOnly = true;
            this.Καθηγητές.Width = 200;
            // 
            // Ιδιότητα
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Ιδιότητα.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ιδιότητα.HeaderText = "Ιδιότητα";
            this.Ιδιότητα.Name = "Ιδιότητα";
            this.Ιδιότητα.ReadOnly = true;
            this.Ιδιότητα.Width = 170;
            // 
            // Γραφείο
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Γραφείο.DefaultCellStyle = dataGridViewCellStyle3;
            this.Γραφείο.HeaderText = "Γραφείο";
            this.Γραφείο.Name = "Γραφείο";
            this.Γραφείο.ReadOnly = true;
            this.Γραφείο.Width = 170;
            // 
            // Τηλέφωνο
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Τηλέφωνο.DefaultCellStyle = dataGridViewCellStyle4;
            this.Τηλέφωνο.HeaderText = "Τηλέφωνο";
            this.Τηλέφωνο.Name = "Τηλέφωνο";
            this.Τηλέφωνο.ReadOnly = true;
            this.Τηλέφωνο.Width = 170;
            // 
            // Email
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Email.DefaultCellStyle = dataGridViewCellStyle5;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(655, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Καθηγητές Τμήματος ΟΔΕ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(339, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Εξαγωγή Δεδομένων";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.panel36.Controls.Add(this.richTextBox8);
            this.panel36.Controls.Add(this.richTextBox9);
            this.panel36.Location = new System.Drawing.Point(1, 633);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(1611, 262);
            this.panel36.TabIndex = 27;
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox8.ForeColor = System.Drawing.Color.White;
            this.richTextBox8.Location = new System.Drawing.Point(996, 23);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.Size = new System.Drawing.Size(335, 174);
            this.richTextBox8.TabIndex = 1;
            this.richTextBox8.Text = "Produced for Academic Purposes\n\nUniversity of Piraeus\n\nΤαχεία Ανάπτυξη Εφαρμογών";
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox9.ForeColor = System.Drawing.Color.White;
            this.richTextBox9.Location = new System.Drawing.Point(102, 23);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.ReadOnly = true;
            this.richTextBox9.Size = new System.Drawing.Size(335, 174);
            this.richTextBox9.TabIndex = 0;
            this.richTextBox9.Text = " ΣΤΟΙΧΕΙΑ ΕΠΙΚΟΙΝΩΝΙΑΣ\n Διεύθυνση: Μ. Καραολή & Α. Δημητρίου 80, \n18534 Πειραιάς\n" +
    "\n Τηλ. Κέντρο: 210 4142000\n\n Fax: 210 4142328";
            // 
            // OdeProfessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 892);
            this.Controls.Add(this.panel36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OdeDataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OdeProfessors";
            this.Text = "OdeProfessors";
            this.Load += new System.EventHandler(this.OdeProfessors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdeDataGrid)).EndInit();
            this.panel36.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OdeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Καθηγητές;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ιδιότητα;
        private System.Windows.Forms.DataGridViewTextBoxColumn Γραφείο;
        private System.Windows.Forms.DataGridViewTextBoxColumn Τηλέφωνο;
        private System.Windows.Forms.DataGridViewLinkColumn Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox9;
    }
}