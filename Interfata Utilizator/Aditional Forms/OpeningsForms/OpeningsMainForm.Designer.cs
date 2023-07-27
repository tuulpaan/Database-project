namespace Interfata_Utilizator.Aditional_Forms.OpeningsForms
{
    partial class OpeningsMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningsMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditOpening = new System.Windows.Forms.Button();
            this.BtnViewOpening = new System.Windows.Forms.Button();
            this.btnAddOpenings = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewOpenings = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpenings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnAddOpenings);
            this.panel1.Controls.Add(this.BtnViewOpening);
            this.panel1.Controls.Add(this.btnEditOpening);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 426);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfata_Utilizator.Properties.Resources.chess;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 243);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditOpening
            // 
            this.btnEditOpening.Location = new System.Drawing.Point(0, 322);
            this.btnEditOpening.Name = "btnEditOpening";
            this.btnEditOpening.Size = new System.Drawing.Size(105, 50);
            this.btnEditOpening.TabIndex = 1;
            this.btnEditOpening.Text = "Edit Opening";
            this.btnEditOpening.UseVisualStyleBackColor = true;
            // 
            // BtnViewOpening
            // 
            this.BtnViewOpening.Location = new System.Drawing.Point(0, 252);
            this.BtnViewOpening.Name = "BtnViewOpening";
            this.BtnViewOpening.Size = new System.Drawing.Size(105, 55);
            this.BtnViewOpening.TabIndex = 2;
            this.BtnViewOpening.Text = "Show Openings";
            this.BtnViewOpening.UseVisualStyleBackColor = true;
            // 
            // btnAddOpenings
            // 
            this.btnAddOpenings.Location = new System.Drawing.Point(143, 252);
            this.btnAddOpenings.Name = "btnAddOpenings";
            this.btnAddOpenings.Size = new System.Drawing.Size(114, 55);
            this.btnAddOpenings.TabIndex = 3;
            this.btnAddOpenings.Text = "Add Opening";
            this.btnAddOpenings.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete Opening";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOpenings
            // 
            this.dataGridViewOpenings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpenings.Location = new System.Drawing.Point(275, 12);
            this.dataGridViewOpenings.Name = "dataGridViewOpenings";
            this.dataGridViewOpenings.Size = new System.Drawing.Size(513, 426);
            this.dataGridViewOpenings.TabIndex = 1;
            // 
            // OpeningsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOpenings);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpeningsMainForm";
            this.Text = "Openings";
            this.Load += new System.EventHandler(this.OpeningsMainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpenings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddOpenings;
        private System.Windows.Forms.Button BtnViewOpening;
        private System.Windows.Forms.Button btnEditOpening;
        private System.Windows.Forms.DataGridView dataGridViewOpenings;
    }
}