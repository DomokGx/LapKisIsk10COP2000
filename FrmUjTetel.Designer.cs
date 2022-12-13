namespace LapKisIsk10COP2000
{
    partial class FrmUjTetel
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
            this.cbNevek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbLeiras = new System.Windows.Forms.TextBox();
            this.dtpMikor = new System.Windows.Forms.DateTimePicker();
            this.nudOsszeg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRogzit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOsszeg)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNevek
            // 
            this.cbNevek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNevek.FormattingEnabled = true;
            this.cbNevek.Location = new System.Drawing.Point(94, 12);
            this.cbNevek.Name = "cbNevek";
            this.cbNevek.Size = new System.Drawing.Size(121, 23);
            this.cbNevek.TabIndex = 0;
            this.cbNevek.SelectedIndexChanged += new System.EventHandler(this.cbNevek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // txtbLeiras
            // 
            this.txtbLeiras.Location = new System.Drawing.Point(95, 120);
            this.txtbLeiras.Name = "txtbLeiras";
            this.txtbLeiras.Size = new System.Drawing.Size(360, 23);
            this.txtbLeiras.TabIndex = 2;
            // 
            // dtpMikor
            // 
            this.dtpMikor.Location = new System.Drawing.Point(94, 47);
            this.dtpMikor.Name = "dtpMikor";
            this.dtpMikor.Size = new System.Drawing.Size(200, 23);
            this.dtpMikor.TabIndex = 3;
            // 
            // nudOsszeg
            // 
            this.nudOsszeg.Location = new System.Drawing.Point(95, 81);
            this.nudOsszeg.Name = "nudOsszeg";
            this.nudOsszeg.Size = new System.Drawing.Size(120, 23);
            this.nudOsszeg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Leírás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Összeg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mikor:";
            // 
            // btnRogzit
            // 
            this.btnRogzit.Enabled = false;
            this.btnRogzit.Location = new System.Drawing.Point(12, 161);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(443, 27);
            this.btnRogzit.TabIndex = 8;
            this.btnRogzit.Text = "Rögzítés";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.BtnRogzit_Click);
            // 
            // FrmUjTetel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 196);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudOsszeg);
            this.Controls.Add(this.dtpMikor);
            this.Controls.Add(this.txtbLeiras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNevek);
            this.Name = "FrmUjTetel";
            this.Text = "Új banki tétel rögzitése";
            ((System.ComponentModel.ISupportInitialize)(this.nudOsszeg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbNevek;
        private Label label1;
        private TextBox txtbLeiras;
        private DateTimePicker dtpMikor;
        private NumericUpDown nudOsszeg;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRogzit;
    }
}