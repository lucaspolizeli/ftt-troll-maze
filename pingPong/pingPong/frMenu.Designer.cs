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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMenu));
            this.btJogar = new System.Windows.Forms.Button();
            this.btRecordes = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.btHowTo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btJogar
            // 
            this.btJogar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJogar.ForeColor = System.Drawing.SystemColors.Window;
            this.btJogar.Location = new System.Drawing.Point(9, 164);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(263, 23);
            this.btJogar.TabIndex = 0;
            this.btJogar.Text = "JOGAR";
            this.btJogar.UseVisualStyleBackColor = false;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // btRecordes
            // 
            this.btRecordes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btRecordes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecordes.ForeColor = System.Drawing.SystemColors.Window;
            this.btRecordes.Location = new System.Drawing.Point(9, 222);
            this.btRecordes.Name = "btRecordes";
            this.btRecordes.Size = new System.Drawing.Size(263, 23);
            this.btRecordes.TabIndex = 1;
            this.btRecordes.Text = "RECORDES";
            this.btRecordes.UseVisualStyleBackColor = false;
            this.btRecordes.Click += new System.EventHandler(this.btRecordes_Click);
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt.ForeColor = System.Drawing.SystemColors.Window;
            this.bt.Location = new System.Drawing.Point(9, 251);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(263, 23);
            this.bt.TabIndex = 2;
            this.bt.Text = "SOBRE";
            this.bt.UseVisualStyleBackColor = false;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // btHowTo
            // 
            this.btHowTo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btHowTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHowTo.ForeColor = System.Drawing.SystemColors.Window;
            this.btHowTo.Location = new System.Drawing.Point(9, 193);
            this.btHowTo.Name = "btHowTo";
            this.btHowTo.Size = new System.Drawing.Size(263, 23);
            this.btHowTo.TabIndex = 3;
            this.btHowTo.Text = "COMO JOGAR";
            this.btHowTo.UseVisualStyleBackColor = false;
            this.btHowTo.Click += new System.EventHandler(this.btHowTo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pingPong.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(11, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(31, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "LABIRINTO";
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btSair.Location = new System.Drawing.Point(9, 309);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(263, 23);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btConfig
            // 
            this.btConfig.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfig.ForeColor = System.Drawing.SystemColors.Window;
            this.btConfig.Location = new System.Drawing.Point(9, 280);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(263, 23);
            this.btConfig.TabIndex = 7;
            this.btConfig.Text = "CONFIGURAÇÕES";
            this.btConfig.UseVisualStyleBackColor = false;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // frMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 338);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btHowTo);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.btRecordes);
            this.Controls.Add(this.btJogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btConfig;
    }
}