namespace pingPong
{
    partial class frConfig
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
            this.btEna = new System.Windows.Forms.Button();
            this.btDes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEna
            // 
            this.btEna.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btEna.Enabled = false;
            this.btEna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEna.ForeColor = System.Drawing.SystemColors.Window;
            this.btEna.Location = new System.Drawing.Point(9, 12);
            this.btEna.Name = "btEna";
            this.btEna.Size = new System.Drawing.Size(263, 23);
            this.btEna.TabIndex = 7;
            this.btEna.Text = "HABILITAR SOM";
            this.btEna.UseVisualStyleBackColor = false;
            this.btEna.Click += new System.EventHandler(this.btEna_Click);
            // 
            // btDes
            // 
            this.btDes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDes.ForeColor = System.Drawing.SystemColors.Window;
            this.btDes.Location = new System.Drawing.Point(9, 41);
            this.btDes.Name = "btDes";
            this.btDes.Size = new System.Drawing.Size(263, 23);
            this.btDes.TabIndex = 8;
            this.btDes.Text = "DESABILITAR SOM";
            this.btDes.UseVisualStyleBackColor = false;
            this.btDes.Click += new System.EventHandler(this.btDes_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(150, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 100);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btDes);
            this.Controls.Add(this.btEna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frConfig";
            this.Text = "frConfig";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEna;
        private System.Windows.Forms.Button btDes;
        private System.Windows.Forms.Button button2;
    }
}