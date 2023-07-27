namespace Interfata_Utilizator.Aditional_Forms.Clienti
{
    partial class ClientiForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteClienti = new System.Windows.Forms.Button();
            this.btnEditClienti = new System.Windows.Forms.Button();
            this.btnAddClienti = new System.Windows.Forms.Button();
            this.btnShowClienti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(752, 437);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnDeleteClienti
            // 
            this.btnDeleteClienti.Location = new System.Drawing.Point(198, 408);
            this.btnDeleteClienti.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteClienti.Name = "btnDeleteClienti";
            this.btnDeleteClienti.Size = new System.Drawing.Size(148, 52);
            this.btnDeleteClienti.TabIndex = 11;
            this.btnDeleteClienti.Text = "Delete";
            this.btnDeleteClienti.UseVisualStyleBackColor = true;
            this.btnDeleteClienti.Click += new System.EventHandler(this.btnDeleteClienti_Click);
            // 
            // btnEditClienti
            // 
            this.btnEditClienti.Location = new System.Drawing.Point(31, 408);
            this.btnEditClienti.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClienti.Name = "btnEditClienti";
            this.btnEditClienti.Size = new System.Drawing.Size(139, 52);
            this.btnEditClienti.TabIndex = 10;
            this.btnEditClienti.Text = "Edit";
            this.btnEditClienti.UseVisualStyleBackColor = true;
            this.btnEditClienti.Click += new System.EventHandler(this.btnEditClienti_Click);
            // 
            // btnAddClienti
            // 
            this.btnAddClienti.Location = new System.Drawing.Point(198, 298);
            this.btnAddClienti.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClienti.Name = "btnAddClienti";
            this.btnAddClienti.Size = new System.Drawing.Size(148, 52);
            this.btnAddClienti.TabIndex = 9;
            this.btnAddClienti.Text = "Add";
            this.btnAddClienti.UseVisualStyleBackColor = true;
            this.btnAddClienti.Click += new System.EventHandler(this.btnAddClienti_Click);
            // 
            // btnShowClienti
            // 
            this.btnShowClienti.Location = new System.Drawing.Point(31, 298);
            this.btnShowClienti.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowClienti.Name = "btnShowClienti";
            this.btnShowClienti.Size = new System.Drawing.Size(139, 52);
            this.btnShowClienti.TabIndex = 8;
            this.btnShowClienti.Text = "Show";
            this.btnShowClienti.UseVisualStyleBackColor = true;
            this.btnShowClienti.Click += new System.EventHandler(this.btnShowClienti_Click);
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 543);
            this.Controls.Add(this.btnDeleteClienti);
            this.Controls.Add(this.btnEditClienti);
            this.Controls.Add(this.btnAddClienti);
            this.Controls.Add(this.btnShowClienti);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientiForm";
            this.Text = "ClientiForm";
            this.Load += new System.EventHandler(this.ClientiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteClienti;
        private System.Windows.Forms.Button btnEditClienti;
        private System.Windows.Forms.Button btnAddClienti;
        private System.Windows.Forms.Button btnShowClienti;
    }
}