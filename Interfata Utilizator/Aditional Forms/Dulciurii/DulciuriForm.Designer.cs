namespace Interfata_Utilizator.Aditional_Forms.Dulciurii
{
    partial class DulciuriForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteDulciuri = new System.Windows.Forms.Button();
            this.btnEditDulciuri = new System.Windows.Forms.Button();
            this.btnAddDulciuri = new System.Windows.Forms.Button();
            this.btnShowDulciuri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(348, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(752, 437);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteDulciuri);
            this.panel1.Controls.Add(this.btnEditDulciuri);
            this.panel1.Controls.Add(this.btnAddDulciuri);
            this.panel1.Controls.Add(this.btnShowDulciuri);
            this.panel1.Location = new System.Drawing.Point(7, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 523);
            this.panel1.TabIndex = 6;
            // 
            // btnDeleteDulciuri
            // 
            this.btnDeleteDulciuri.Location = new System.Drawing.Point(185, 372);
            this.btnDeleteDulciuri.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDulciuri.Name = "btnDeleteDulciuri";
            this.btnDeleteDulciuri.Size = new System.Drawing.Size(148, 52);
            this.btnDeleteDulciuri.TabIndex = 4;
            this.btnDeleteDulciuri.Text = "Delete";
            this.btnDeleteDulciuri.UseVisualStyleBackColor = true;
            this.btnDeleteDulciuri.Click += new System.EventHandler(this.btnDeleteDulciuri_Click);
            // 
            // btnEditDulciuri
            // 
            this.btnEditDulciuri.Location = new System.Drawing.Point(0, 372);
            this.btnEditDulciuri.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditDulciuri.Name = "btnEditDulciuri";
            this.btnEditDulciuri.Size = new System.Drawing.Size(139, 52);
            this.btnEditDulciuri.TabIndex = 3;
            this.btnEditDulciuri.Text = "Edit";
            this.btnEditDulciuri.UseVisualStyleBackColor = true;
            this.btnEditDulciuri.Click += new System.EventHandler(this.btnEditDulciuri_Click);
            // 
            // btnAddDulciuri
            // 
            this.btnAddDulciuri.Location = new System.Drawing.Point(185, 313);
            this.btnAddDulciuri.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDulciuri.Name = "btnAddDulciuri";
            this.btnAddDulciuri.Size = new System.Drawing.Size(148, 52);
            this.btnAddDulciuri.TabIndex = 2;
            this.btnAddDulciuri.Text = "Add";
            this.btnAddDulciuri.UseVisualStyleBackColor = true;
            this.btnAddDulciuri.Click += new System.EventHandler(this.btnAddDulciuri_Click);
            // 
            // btnShowDulciuri
            // 
            this.btnShowDulciuri.Location = new System.Drawing.Point(0, 312);
            this.btnShowDulciuri.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDulciuri.Name = "btnShowDulciuri";
            this.btnShowDulciuri.Size = new System.Drawing.Size(139, 52);
            this.btnShowDulciuri.TabIndex = 1;
            this.btnShowDulciuri.Text = "Show";
            this.btnShowDulciuri.UseVisualStyleBackColor = true;
            this.btnShowDulciuri.Click += new System.EventHandler(this.btnShowDulciuri_Click);
            // 
            // DulciuriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DulciuriForm";
            this.Text = "DulciuriForm";
            this.Load += new System.EventHandler(this.DulciuriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteDulciuri;
        private System.Windows.Forms.Button btnEditDulciuri;
        private System.Windows.Forms.Button btnAddDulciuri;
        private System.Windows.Forms.Button btnShowDulciuri;
    }
}