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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.σχολέςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.τμήμαΠληροφορικήςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.καθηγητέςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.τμήμαΟΔΕToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.καθηγητέςToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.τμήμαΟικονομικώνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.καθηγητέςToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εκδηλώσειςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.InformaticsDataGrid)).BeginInit();
            this.panel36.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(492, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 31);
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
            this.InformaticsDataGrid.Location = new System.Drawing.Point(224, 147);
            this.InformaticsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.InformaticsDataGrid.Name = "InformaticsDataGrid";
            this.InformaticsDataGrid.RowHeadersWidth = 51;
            this.InformaticsDataGrid.Size = new System.Drawing.Size(954, 366);
            this.InformaticsDataGrid.TabIndex = 3;
            this.InformaticsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Καθηγητές
            // 
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Καθηγητές.DefaultCellStyle = dataGridViewCellStyle61;
            this.Καθηγητές.HeaderText = "Καθηγητές";
            this.Καθηγητές.MinimumWidth = 6;
            this.Καθηγητές.Name = "Καθηγητές";
            this.Καθηγητές.ReadOnly = true;
            this.Καθηγητές.Width = 200;
            // 
            // Ιδιότητα
            // 
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Ιδιότητα.DefaultCellStyle = dataGridViewCellStyle62;
            this.Ιδιότητα.HeaderText = "Ιδιότητα";
            this.Ιδιότητα.MinimumWidth = 6;
            this.Ιδιότητα.Name = "Ιδιότητα";
            this.Ιδιότητα.ReadOnly = true;
            this.Ιδιότητα.Width = 170;
            // 
            // Γραφείο
            // 
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Γραφείο.DefaultCellStyle = dataGridViewCellStyle63;
            this.Γραφείο.HeaderText = "Γραφείο";
            this.Γραφείο.MinimumWidth = 6;
            this.Γραφείο.Name = "Γραφείο";
            this.Γραφείο.ReadOnly = true;
            this.Γραφείο.Width = 170;
            // 
            // Τηλέφωνο
            // 
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Τηλέφωνο.DefaultCellStyle = dataGridViewCellStyle64;
            this.Τηλέφωνο.HeaderText = "Τηλέφωνο";
            this.Τηλέφωνο.MinimumWidth = 6;
            this.Τηλέφωνο.Name = "Τηλέφωνο";
            this.Τηλέφωνο.ReadOnly = true;
            this.Τηλέφωνο.Width = 170;
            // 
            // Email
            // 
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Email.DefaultCellStyle = dataGridViewCellStyle65;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(224, 101);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.reviewsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.σχολέςToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.εκδηλώσειςToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1611, 32);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(138, 28);
            this.mainToolStripMenuItem.Text = "Αρχική Σελίδα";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // reviewsToolStripMenuItem
            // 
            this.reviewsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.reviewsToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.reviewsToolStripMenuItem.Text = "Reviews";
            this.reviewsToolStripMenuItem.Click += new System.EventHandler(this.reviewsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // σχολέςToolStripMenuItem
            // 
            this.σχολέςToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.τμήμαΠληροφορικήςToolStripMenuItem,
            this.τμήμαΟΔΕToolStripMenuItem,
            this.τμήμαΟικονομικώνToolStripMenuItem});
            this.σχολέςToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.σχολέςToolStripMenuItem.Name = "σχολέςToolStripMenuItem";
            this.σχολέςToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.σχολέςToolStripMenuItem.Text = "Τμήματα";
            // 
            // τμήμαΠληροφορικήςToolStripMenuItem
            // 
            this.τμήμαΠληροφορικήςToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.καθηγητέςToolStripMenuItem});
            this.τμήμαΠληροφορικήςToolStripMenuItem.Name = "τμήμαΠληροφορικήςToolStripMenuItem";
            this.τμήμαΠληροφορικήςToolStripMenuItem.Size = new System.Drawing.Size(273, 28);
            this.τμήμαΠληροφορικήςToolStripMenuItem.Text = "Τμήμα Πληροφορικής";
            this.τμήμαΠληροφορικήςToolStripMenuItem.Click += new System.EventHandler(this.τμήμαΠληροφορικήςToolStripMenuItem_Click);
            // 
            // καθηγητέςToolStripMenuItem
            // 
            this.καθηγητέςToolStripMenuItem.Name = "καθηγητέςToolStripMenuItem";
            this.καθηγητέςToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.καθηγητέςToolStripMenuItem.Text = "Καθηγητές";
            this.καθηγητέςToolStripMenuItem.Click += new System.EventHandler(this.καθηγητέςToolStripMenuItem_Click);
            // 
            // τμήμαΟΔΕToolStripMenuItem
            // 
            this.τμήμαΟΔΕToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.καθηγητέςToolStripMenuItem1});
            this.τμήμαΟΔΕToolStripMenuItem.Name = "τμήμαΟΔΕToolStripMenuItem";
            this.τμήμαΟΔΕToolStripMenuItem.Size = new System.Drawing.Size(273, 28);
            this.τμήμαΟΔΕToolStripMenuItem.Text = "Τμήμα ΟΔΕ";
            this.τμήμαΟΔΕToolStripMenuItem.Click += new System.EventHandler(this.τμήμαΟΔΕToolStripMenuItem_Click);
            // 
            // καθηγητέςToolStripMenuItem1
            // 
            this.καθηγητέςToolStripMenuItem1.Name = "καθηγητέςToolStripMenuItem1";
            this.καθηγητέςToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.καθηγητέςToolStripMenuItem1.Text = "Καθηγητές";
            this.καθηγητέςToolStripMenuItem1.Click += new System.EventHandler(this.καθηγητέςToolStripMenuItem1_Click);
            // 
            // τμήμαΟικονομικώνToolStripMenuItem
            // 
            this.τμήμαΟικονομικώνToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.καθηγητέςToolStripMenuItem2});
            this.τμήμαΟικονομικώνToolStripMenuItem.Name = "τμήμαΟικονομικώνToolStripMenuItem";
            this.τμήμαΟικονομικώνToolStripMenuItem.Size = new System.Drawing.Size(273, 28);
            this.τμήμαΟικονομικώνToolStripMenuItem.Text = "Τμήμα Οικονομικών";
            this.τμήμαΟικονομικώνToolStripMenuItem.Click += new System.EventHandler(this.τμήμαΟικονομικώνToolStripMenuItem_Click);
            // 
            // καθηγητέςToolStripMenuItem2
            // 
            this.καθηγητέςToolStripMenuItem2.Name = "καθηγητέςToolStripMenuItem2";
            this.καθηγητέςToolStripMenuItem2.Size = new System.Drawing.Size(224, 28);
            this.καθηγητέςToolStripMenuItem2.Text = "Καθηγητές";
            this.καθηγητέςToolStripMenuItem2.Click += new System.EventHandler(this.καθηγητέςToolStripMenuItem2_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.aboutToolStripMenuItem.Text = "Βιντεο";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // εκδηλώσειςToolStripMenuItem
            // 
            this.εκδηλώσειςToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.εκδηλώσειςToolStripMenuItem.Name = "εκδηλώσειςToolStripMenuItem";
            this.εκδηλώσειςToolStripMenuItem.Size = new System.Drawing.Size(119, 28);
            this.εκδηλώσειςToolStripMenuItem.Text = "Εκδηλώσεις";
            this.εκδηλώσειςToolStripMenuItem.Click += new System.EventHandler(this.εκδηλώσειςToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(76, 28);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // InformaticsProfessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 892);
            this.Controls.Add(this.menuStrip1);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem σχολέςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem τμήμαΠληροφορικήςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem καθηγητέςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem τμήμαΟΔΕToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem καθηγητέςToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem τμήμαΟικονομικώνToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem καθηγητέςToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εκδηλώσειςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}