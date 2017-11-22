namespace pingPong
{
    partial class frSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frSobre));
            this.lblDev = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTfECHAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDev.Location = new System.Drawing.Point(15, 34);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(302, 37);
            this.lblDev.TabIndex = 0;
            this.lblDev.Text = "Desenvolvedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Murilo Parra Pires                        RA: 081170017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lucas Martin Polizeli da Silva      RA: 081170029";
            // 
            // BTfECHAR
            // 
            this.BTfECHAR.BackColor = System.Drawing.Color.MintCream;
            this.BTfECHAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTfECHAR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTfECHAR.Location = new System.Drawing.Point(277, -2);
            this.BTfECHAR.Name = "BTfECHAR";
            this.BTfECHAR.Size = new System.Drawing.Size(52, 33);
            this.BTfECHAR.TabIndex = 4;
            this.BTfECHAR.Text = "X";
            this.BTfECHAR.UseVisualStyleBackColor = false;
            this.BTfECHAR.Click += new System.EventHandler(this.BTfECHAR_Click);
            // 
            // frSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 150);
            this.Controls.Add(this.BTfECHAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTfECHAR;
    }
}