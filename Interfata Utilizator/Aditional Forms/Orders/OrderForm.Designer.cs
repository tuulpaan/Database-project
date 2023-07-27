namespace Interfata_Utilizator.Aditional_Forms.Orders
{
    partial class OrderForm
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
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            this.btnEditOrders = new System.Windows.Forms.Button();
            this.btnAddOrders = new System.Windows.Forms.Button();
            this.btnShowOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.Location = new System.Drawing.Point(211, 401);
            this.btnDeleteOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(148, 52);
            this.btnDeleteOrders.TabIndex = 15;
            this.btnDeleteOrders.Text = "Delete";
            this.btnDeleteOrders.UseVisualStyleBackColor = true;
            this.btnDeleteOrders.Click += new System.EventHandler(this.btnDeleteOrders_Click);
            // 
            // btnEditOrders
            // 
            this.btnEditOrders.Location = new System.Drawing.Point(44, 401);
            this.btnEditOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditOrders.Name = "btnEditOrders";
            this.btnEditOrders.Size = new System.Drawing.Size(139, 52);
            this.btnEditOrders.TabIndex = 14;
            this.btnEditOrders.Text = "Edit";
            this.btnEditOrders.UseVisualStyleBackColor = true;
            this.btnEditOrders.Click += new System.EventHandler(this.btnEditOrders_Click);
            // 
            // btnAddOrders
            // 
            this.btnAddOrders.Location = new System.Drawing.Point(211, 291);
            this.btnAddOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOrders.Name = "btnAddOrders";
            this.btnAddOrders.Size = new System.Drawing.Size(148, 52);
            this.btnAddOrders.TabIndex = 13;
            this.btnAddOrders.Text = "Add";
            this.btnAddOrders.UseVisualStyleBackColor = true;
            this.btnAddOrders.Click += new System.EventHandler(this.btnAddOrders_Click);
            // 
            // btnShowOrders
            // 
            this.btnShowOrders.Location = new System.Drawing.Point(44, 291);
            this.btnShowOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowOrders.Name = "btnShowOrders";
            this.btnShowOrders.Size = new System.Drawing.Size(139, 52);
            this.btnShowOrders.TabIndex = 12;
            this.btnShowOrders.Text = "Show";
            this.btnShowOrders.UseVisualStyleBackColor = true;
            this.btnShowOrders.Click += new System.EventHandler(this.btnShowOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 384);
            this.dataGridView1.TabIndex = 16;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteOrders);
            this.Controls.Add(this.btnEditOrders);
            this.Controls.Add(this.btnAddOrders);
            this.Controls.Add(this.btnShowOrders);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteOrders;
        private System.Windows.Forms.Button btnEditOrders;
        private System.Windows.Forms.Button btnAddOrders;
        private System.Windows.Forms.Button btnShowOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}