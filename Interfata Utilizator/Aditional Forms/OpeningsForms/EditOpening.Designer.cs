namespace Interfata_Utilizator.Aditional_Forms.OpeningsForms
{
    partial class EditOpening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOpening));
            this.lblTipJoc = new System.Windows.Forms.Label();
            this.lblTipDeJoc = new System.Windows.Forms.Label();
            this.lblAgr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipJoc
            // 
            this.lblTipJoc.AutoSize = true;
            this.lblTipJoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipJoc.Location = new System.Drawing.Point(33, 120);
            this.lblTipJoc.Name = "lblTipJoc";
            this.lblTipJoc.Size = new System.Drawing.Size(107, 13);
            this.lblTipJoc.TabIndex = 2;
            this.lblTipJoc.Text = "Nume Deschidere";
            // 
            // lblTipDeJoc
            // 
            this.lblTipDeJoc.AutoSize = true;
            this.lblTipDeJoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipDeJoc.Location = new System.Drawing.Point(45, 160);
            this.lblTipDeJoc.Name = "lblTipDeJoc";
            this.lblTipDeJoc.Size = new System.Drawing.Size(67, 13);
            this.lblTipDeJoc.TabIndex = 3;
            this.lblTipDeJoc.Text = "Tip de Joc";
            // 
            // lblAgr
            // 
            this.lblAgr.AutoSize = true;
            this.lblAgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgr.Location = new System.Drawing.Point(45, 205);
            this.lblAgr.Name = "lblAgr";
            this.lblAgr.Size = new System.Drawing.Size(74, 13);
            this.lblAgr.TabIndex = 4;
            this.lblAgr.Text = "Agresivitate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(298, 21);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(182, 31);
            this.LblTitle.TabIndex = 14;
            this.LblTitle.Text = "Edit Opening";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(104, 267);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // EditOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAgr);
            this.Controls.Add(this.lblTipDeJoc);
            this.Controls.Add(this.lblTipJoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditOpening";
            this.Text = "Edit Opening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipJoc;
        private System.Windows.Forms.Label lblTipDeJoc;
        private System.Windows.Forms.Label lblAgr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button btnSubmit;
    }
}