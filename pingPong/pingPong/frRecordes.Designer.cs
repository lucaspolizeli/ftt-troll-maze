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
            this.lboxRecordes = new System.Windows.Forms.ListBox();
            this.lblTituloGamerds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboxRecordes
            // 
            this.lboxRecordes.FormattingEnabled = true;
            this.lboxRecordes.Location = new System.Drawing.Point(12, 77);
            this.lboxRecordes.Name = "lboxRecordes";
            this.lboxRecordes.Size = new System.Drawing.Size(260, 173);
            this.lboxRecordes.TabIndex = 0;
            // 
            // lblTituloGamerds
            // 
            this.lblTituloGamerds.AutoSize = true;
            this.lblTituloGamerds.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGamerds.ForeColor = System.Drawing.Color.Navy;
            this.lblTituloGamerds.Location = new System.Drawing.Point(59, 7);
            this.lblTituloGamerds.Name = "lblTituloGamerds";
            this.lblTituloGamerds.Size = new System.Drawing.Size(164, 37);
            this.lblTituloGamerds.TabIndex = 1;
            this.lblTituloGamerds.Text = "Recordes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veja os sortudos que fizeram história!";
            // 
            // frRecordes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloGamerds);
            this.Controls.Add(this.lboxRecordes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}