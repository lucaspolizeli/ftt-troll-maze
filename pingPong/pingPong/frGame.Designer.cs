namespace pingPong
{
    partial class frGame
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
            this.components = new System.ComponentModel.Container();
            this.Player = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GameRoutine = new System.Windows.Forms.Timer(this.components);
            this.fallingBlock1 = new System.Windows.Forms.PictureBox();
            this.fallingBlock2 = new System.Windows.Forms.PictureBox();
            this.fallingBlock3 = new System.Windows.Forms.PictureBox();
            this.fallingBlock4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallingBlock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallingBlock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallingBlock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallingBlock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Red;
            this.Player.Location = new System.Drawing.Point(58, 48);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(18, 18);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clique nesse quadradinho fofuxo para começar";
            // 
            // GameRoutine
            // 
            this.GameRoutine.Interval = 20;
            this.GameRoutine.Tick += new System.EventHandler(this.GameRoutine_Tick);
            // 
            // fallingBlock1
            // 
            this.fallingBlock1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fallingBlock1.Location = new System.Drawing.Point(547, 158);
            this.fallingBlock1.Name = "fallingBlock1";
            this.fallingBlock1.Size = new System.Drawing.Size(18, 54);
            this.fallingBlock1.TabIndex = 2;
            this.fallingBlock1.TabStop = false;
            // 
            // fallingBlock2
            // 
            this.fallingBlock2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fallingBlock2.Location = new System.Drawing.Point(591, 158);
            this.fallingBlock2.Name = "fallingBlock2";
            this.fallingBlock2.Size = new System.Drawing.Size(18, 24);
            this.fallingBlock2.TabIndex = 3;
            this.fallingBlock2.TabStop = false;
            // 
            // fallingBlock3
            // 
            this.fallingBlock3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fallingBlock3.Location = new System.Drawing.Point(634, 158);
            this.fallingBlock3.Name = "fallingBlock3";
            this.fallingBlock3.Size = new System.Drawing.Size(18, 54);
            this.fallingBlock3.TabIndex = 4;
            this.fallingBlock3.TabStop = false;
            // 
            // fallingBlock4
            // 
            this.fallingBlock4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fallingBlock4.Location = new System.Drawing.Point(680, 158);
            this.fallingBlock4.Name = "fallingBlock4";
            this.fallingBlock4.Size = new System.Drawing.Size(18, 24);
            this.fallingBlock4.TabIndex = 5;
            this.fallingBlock4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.Location = new System.Drawing.Point(12, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(119, 12);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.Location = new System.Drawing.Point(113, 30);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(18, 36);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.Location = new System.Drawing.Point(12, 102);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(247, 19);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox8.Location = new System.Drawing.Point(113, 48);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(187, 18);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox9.Location = new System.Drawing.Point(293, 48);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(17, 111);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox10.Location = new System.Drawing.Point(293, 158);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(405, 24);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(242, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 129);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(242, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 21);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // frGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.fallingBlock4);
            this.Controls.Add(this.fallingBlock3);
            this.Controls.Add(this.fallingBlock2);
            this.Controls.Add(this.fallingBlock1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Name = "frGame";
            this.Text = "frGame";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallingBlock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallingBlock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallingBlock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallingBlock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer GameRoutine;
        private System.Windows.Forms.PictureBox fallingBlock1;
        private System.Windows.Forms.PictureBox fallingBlock2;
        private System.Windows.Forms.PictureBox fallingBlock3;
        private System.Windows.Forms.PictureBox fallingBlock4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}