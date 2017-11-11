namespace pingPong
{
    partial class frGameOver
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
            this.Pontuacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pontuacao
            // 
            this.Pontuacao.AutoSize = true;
            this.Pontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Pontuacao.Location = new System.Drawing.Point(73, 61);
            this.Pontuacao.Name = "Pontuacao";
            this.Pontuacao.Size = new System.Drawing.Size(0, 31);
            this.Pontuacao.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "FIM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pontuacao);
            this.Name = "frGameOver";
            this.Text = "frGameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Pontuacao;
        public System.Windows.Forms.Button button1;
    }
}