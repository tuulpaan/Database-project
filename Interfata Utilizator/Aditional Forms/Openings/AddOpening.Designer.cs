namespace Interfata_Utilizator.Aditional_Forms.Openings
{
    partial class AddOpening
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNumeDeschidere = new System.Windows.Forms.Label();
            this.lblTipDeJoc = new System.Windows.Forms.Label();
            this.lblAgresivitate = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(51, 66);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblNumeDeschidere
            // 
            this.lblNumeDeschidere.AutoSize = true;
            this.lblNumeDeschidere.Location = new System.Drawing.Point(51, 116);
            this.lblNumeDeschidere.Name = "lblNumeDeschidere";
            this.lblNumeDeschidere.Size = new System.Drawing.Size(92, 13);
            this.lblNumeDeschidere.TabIndex = 2;
            this.lblNumeDeschidere.Text = "Nume Deschidere";
            // 
            // lblTipDeJoc
            // 
            this.lblTipDeJoc.AutoSize = true;
            this.lblTipDeJoc.Location = new System.Drawing.Point(51, 165);
            this.lblTipDeJoc.Name = "lblTipDeJoc";
            this.lblTipDeJoc.Size = new System.Drawing.Size(57, 13);
            this.lblTipDeJoc.TabIndex = 3;
            this.lblTipDeJoc.Text = "Tip de Joc";
            // 
            // lblAgresivitate
            // 
            this.lblAgresivitate.AutoSize = true;
            this.lblAgresivitate.Location = new System.Drawing.Point(51, 210);
            this.lblAgresivitate.Name = "lblAgresivitate";
            this.lblAgresivitate.Size = new System.Drawing.Size(62, 13);
            this.lblAgresivitate.TabIndex = 4;
            this.lblAgresivitate.Text = "Agresivitate";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 20);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gambit",
            "Foarte Agresiv",
            "Agresiv",
            "Normal",
            "Defensiv",
            "Pasiv"});
            this.comboBox1.Location = new System.Drawing.Point(115, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Deschis",
            "Semi-Deschis",
            "Inchis"});
            this.comboBox2.Location = new System.Drawing.Point(115, 165);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(252, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // AddOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblAgresivitate);
            this.Controls.Add(this.lblTipDeJoc);
            this.Controls.Add(this.lblNumeDeschidere);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textBox1);
            this.Name = "AddOpening";
            this.Text = "Add Opening";
            this.Load += new System.EventHandler(this.AddOpening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNumeDeschidere;
        private System.Windows.Forms.Label lblTipDeJoc;
        private System.Windows.Forms.Label lblAgresivitate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}