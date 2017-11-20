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
            this.lblTituloGamerds.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGamerds.Location = new System.Drawing.Point(71, 23);
            this.lblTituloGamerds.Name = "lblTituloGamerds";
            this.lblTituloGamerds.Size = new System.Drawing.Size(140, 33);
            this.lblTituloGamerds.TabIndex = 1;
            this.lblTituloGamerds.Text = "Recordes";
            // 
            // frRecordes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblTituloGamerds);
            this.Controls.Add(this.lboxRecordes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frRecordes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxRecordes;
        private System.Windows.Forms.Label lblTituloGamerds;
    }
}