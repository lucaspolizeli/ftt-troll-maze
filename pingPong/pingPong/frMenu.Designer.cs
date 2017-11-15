namespace pingPong
{
    partial class frMenu
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
            this.btJogar = new System.Windows.Forms.Button();
            this.btRecordes = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btJogar
            // 
            this.btJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJogar.Location = new System.Drawing.Point(12, 144);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(175, 23);
            this.btJogar.TabIndex = 0;
            this.btJogar.Text = "JOGAR";
            this.btJogar.UseVisualStyleBackColor = true;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // btRecordes
            // 
            this.btRecordes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecordes.Location = new System.Drawing.Point(12, 173);
            this.btRecordes.Name = "btRecordes";
            this.btRecordes.Size = new System.Drawing.Size(175, 23);
            this.btRecordes.TabIndex = 1;
            this.btRecordes.Text = "RECORDES";
            this.btRecordes.UseVisualStyleBackColor = true;
            this.btRecordes.Click += new System.EventHandler(this.btRecordes_Click);
            // 
            // bt
            // 
            this.bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt.Location = new System.Drawing.Point(12, 202);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(175, 23);
            this.bt.TabIndex = 2;
            this.bt.Text = "SOBRE";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // frMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 271);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.btRecordes);
            this.Controls.Add(this.btJogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Button btRecordes;
        private System.Windows.Forms.Button bt;
    }
}