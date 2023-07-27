namespace Interfata_Utilizator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnDulciuri = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDulciuri
            // 
            this.btnDulciuri.BackColor = System.Drawing.Color.Violet;
            this.btnDulciuri.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDulciuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDulciuri.Location = new System.Drawing.Point(314, 282);
            this.btnDulciuri.Margin = new System.Windows.Forms.Padding(4);
            this.btnDulciuri.Name = "btnDulciuri";
            this.btnDulciuri.Size = new System.Drawing.Size(259, 81);
            this.btnDulciuri.TabIndex = 2;
            this.btnDulciuri.Text = "Dulciuri";
            this.btnDulciuri.UseVisualStyleBackColor = false;
            this.btnDulciuri.Click += new System.EventHandler(this.btnDulciuri_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.BackColor = System.Drawing.Color.Violet;
            this.btnClienti.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClienti.Location = new System.Drawing.Point(314, 385);
            this.btnClienti.Margin = new System.Windows.Forms.Padding(4);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(259, 81);
            this.btnClienti.TabIndex = 3;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = false;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnComenzi
            // 
            this.btnComenzi.BackColor = System.Drawing.Color.Violet;
            this.btnComenzi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnComenzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComenzi.Location = new System.Drawing.Point(660, 325);
            this.btnComenzi.Margin = new System.Windows.Forms.Padding(4);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(259, 81);
            this.btnComenzi.TabIndex = 4;
            this.btnComenzi.Text = "Comenzi";
            this.btnComenzi.UseVisualStyleBackColor = false;
            this.btnComenzi.Click += new System.EventHandler(this.btnComenzi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnComenzi);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnDulciuri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Bakery LK";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDulciuri;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnComenzi;
    }
}

