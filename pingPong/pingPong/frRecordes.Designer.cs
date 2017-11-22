namespace pingPong
{
    partial class frRecordes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frRecordes));
            this.lboxRecordes = new System.Windows.Forms.ListBox();
            this.lblTituloGamerds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxRecordes
            // 
            this.lboxRecordes.FormattingEnabled = true;
            this.lboxRecordes.Location = new System.Drawing.Point(12, 77);
            this.lboxRecordes.Name = "lboxRecordes";
            this.lboxRecordes.Size = new System.Drawing.Size(260, 199);
            this.lboxRecordes.TabIndex = 0;
            // 
            // lblTituloGamerds
            // 
            this.lblTituloGamerds.AutoSize = true;
            this.lblTituloGamerds.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGamerds.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTituloGamerds.Location = new System.Drawing.Point(61, 7);
            this.lblTituloGamerds.Name = "lblTituloGamerds";
            this.lblTituloGamerds.Size = new System.Drawing.Size(164, 37);
            this.lblTituloGamerds.TabIndex = 1;
            this.lblTituloGamerds.Text = "Recordes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veja os sortudos que fizeram história!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(12, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frRecordes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloGamerds);
            this.Controls.Add(this.lboxRecordes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frRecordes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordes";
            this.Load += new System.EventHandler(this.frRecordes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxRecordes;
        private System.Windows.Forms.Label lblTituloGamerds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}