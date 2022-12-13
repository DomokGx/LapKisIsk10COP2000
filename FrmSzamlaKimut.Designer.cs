namespace LapKisIsk10COP2000
{
    partial class FrmSzamlaKimut
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
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHonap = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(137, 73);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(121, 26);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hónap:";
            // 
            // cbHonap
            // 
            this.cbHonap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHonap.FormattingEnabled = true;
            this.cbHonap.Location = new System.Drawing.Point(189, 29);
            this.cbHonap.Name = "cbHonap";
            this.cbHonap.Size = new System.Drawing.Size(69, 23);
            this.cbHonap.TabIndex = 0;
            this.cbHonap.SelectedIndexChanged += new System.EventHandler(this.CbHonap_SelectedIndexChanged);
            // 
            // FrmSzamlaKimut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cbHonap);
            this.Name = "FrmSzamlaKimut";
            this.Text = "Számla kimutatás";
            this.Load += new System.EventHandler(this.FrmSzamlaKimut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnExport;
        private Label label1;
        private ComboBox cbHonap;
    }
}