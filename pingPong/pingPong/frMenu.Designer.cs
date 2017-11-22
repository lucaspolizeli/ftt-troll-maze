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
            this.btHowTo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btJogar
            // 
            this.btJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJogar.Location = new System.Drawing.Point(9, 164);
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
            this.btRecordes.Location = new System.Drawing.Point(9, 222);
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
            this.bt.Location = new System.Drawing.Point(9, 251);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(175, 23);
            this.bt.TabIndex = 2;
            this.bt.Text = "SOBRE";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // btHowTo
            // 
            this.btHowTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHowTo.Location = new System.Drawing.Point(9, 193);
            this.btHowTo.Name = "btHowTo";
            this.btHowTo.Size = new System.Drawing.Size(175, 23);
            this.btHowTo.TabIndex = 3;
            this.btHowTo.Text = "COMO JOGAR";
            this.btHowTo.UseVisualStyleBackColor = true;
            this.btHowTo.Click += new System.EventHandler(this.btHowTo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pingPong.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(9, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "LABIRINTO";
            // 
            // frMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btHowTo);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.btRecordes);
            this.Controls.Add(this.btJogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Button btRecordes;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Button btHowTo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}