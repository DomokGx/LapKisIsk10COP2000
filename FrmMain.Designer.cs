namespace LapKisIsk10COP2000
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOsszesito = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFenymasolasraOsszesen = new System.Windows.Forms.TextBox();
            this.cbDiakok = new System.Windows.Forms.ComboBox();
            this.rtdDiakTranzakcioi = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUjTetel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSzamlaKimut = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsszesito)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOsszesito
            // 
            this.dgvOsszesito.AllowUserToAddRows = false;
            this.dgvOsszesito.AllowUserToDeleteRows = false;
            this.dgvOsszesito.AllowUserToResizeColumns = false;
            this.dgvOsszesito.AllowUserToResizeRows = false;
            this.dgvOsszesito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsszesito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsszesito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1});
            this.dgvOsszesito.Location = new System.Drawing.Point(12, 12);
            this.dgvOsszesito.Name = "dgvOsszesito";
            this.dgvOsszesito.ReadOnly = true;
            this.dgvOsszesito.RowHeadersVisible = false;
            this.dgvOsszesito.RowTemplate.Height = 25;
            this.dgvOsszesito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsszesito.Size = new System.Drawing.Size(240, 321);
            this.dgvOsszesito.TabIndex = 0;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "NÉV";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Befizetés";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "fénymásolásra:";
            // 
            // tbFenymasolasraOsszesen
            // 
            this.tbFenymasolasraOsszesen.Location = new System.Drawing.Point(373, 18);
            this.tbFenymasolasraOsszesen.Name = "tbFenymasolasraOsszesen";
            this.tbFenymasolasraOsszesen.ReadOnly = true;
            this.tbFenymasolasraOsszesen.Size = new System.Drawing.Size(135, 23);
            this.tbFenymasolasraOsszesen.TabIndex = 2;
            // 
            // cbDiakok
            // 
            this.cbDiakok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiakok.Location = new System.Drawing.Point(281, 66);
            this.cbDiakok.Name = "cbDiakok";
            this.cbDiakok.Size = new System.Drawing.Size(227, 23);
            this.cbDiakok.TabIndex = 3;
            this.cbDiakok.SelectedIndexChanged += new System.EventHandler(this.CbDiakok_SelectedIndexChanged);
            // 
            // rtdDiakTranzakcioi
            // 
            this.rtdDiakTranzakcioi.Location = new System.Drawing.Point(281, 114);
            this.rtdDiakTranzakcioi.Name = "rtdDiakTranzakcioi";
            this.rtdDiakTranzakcioi.Size = new System.Drawing.Size(227, 219);
            this.rtdDiakTranzakcioi.TabIndex = 4;
            this.rtdDiakTranzakcioi.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUjTetel,
            this.menuSzamlaKimut});
            this.menuStrip1.Location = new System.Drawing.Point(535, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(105, 345);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUjTetel
            // 
            this.menuUjTetel.BackColor = System.Drawing.Color.AliceBlue;
            this.menuUjTetel.Margin = new System.Windows.Forms.Padding(5);
            this.menuUjTetel.Name = "menuUjTetel";
            this.menuUjTetel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuUjTetel.Size = new System.Drawing.Size(82, 29);
            this.menuUjTetel.Text = "új tétel";
            this.menuUjTetel.Click += new System.EventHandler(this.MenuUjTetel_Click);
            // 
            // menuSzamlaKimut
            // 
            this.menuSzamlaKimut.BackColor = System.Drawing.Color.AliceBlue;
            this.menuSzamlaKimut.Margin = new System.Windows.Forms.Padding(5);
            this.menuSzamlaKimut.Name = "menuSzamlaKimut";
            this.menuSzamlaKimut.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuSzamlaKimut.Size = new System.Drawing.Size(82, 29);
            this.menuSzamlaKimut.Text = "számla kimut";
            this.menuSzamlaKimut.Click += new System.EventHandler(this.MenuSzamlaKimut_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 345);
            this.Controls.Add(this.rtdDiakTranzakcioi);
            this.Controls.Add(this.cbDiakok);
            this.Controls.Add(this.tbFenymasolasraOsszesen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOsszesito);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Osztálypénztár összesítő";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsszesito)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOsszesito;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private Label label1;
        private TextBox tbFenymasolasraOsszesen;
        private ComboBox cbDiakok;
        private RichTextBox rtdDiakTranzakcioi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuUjTetel;
        private ToolStripMenuItem menuSzamlaKimut;
    }
}