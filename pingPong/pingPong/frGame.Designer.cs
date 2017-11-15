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
            this.label1 = new System.Windows.Forms.Label();
            this.GameRoutine = new System.Windows.Forms.Timer(this.components);
            this.collisionWall3 = new pingPong.CollisionWall();
            this.collisionWall2 = new pingPong.CollisionWall();
            this.movableCollisionWallV1 = new pingPong.MovableCollisionWallV();
            this.player1 = new pingPong.Player();
            this.collisionWall1 = new pingPong.CollisionWall();
            this.collisionWall4 = new pingPong.CollisionWall();
            this.collisionWall5 = new pingPong.CollisionWall();
            this.collisionWall6 = new pingPong.CollisionWall();
            this.collisionWall7 = new pingPong.CollisionWall();
            this.SuspendLayout();
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
            // collisionWall3
            // 
            this.collisionWall3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collisionWall3.Location = new System.Drawing.Point(27, 111);
            this.collisionWall3.Name = "collisionWall3";
            this.collisionWall3.Size = new System.Drawing.Size(150, 10);
            this.collisionWall3.TabIndex = 18;
            // 
            // collisionWall2
            // 
            this.collisionWall2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collisionWall2.Location = new System.Drawing.Point(385, 273);
            this.collisionWall2.Name = "collisionWall2";
            this.collisionWall2.Size = new System.Drawing.Size(150, 150);
            this.collisionWall2.TabIndex = 17;
            // 
            // movableCollisionWallV1
            // 
            this.movableCollisionWallV1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movableCollisionWallV1.Location = new System.Drawing.Point(279, 77);
            this.movableCollisionWallV1.MaxY = 100;
            this.movableCollisionWallV1.MinY = -100;
            this.movableCollisionWallV1.Name = "movableCollisionWallV1";
            this.movableCollisionWallV1.Size = new System.Drawing.Size(14, 100);
            this.movableCollisionWallV1.TabIndex = 15;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Red;
            this.player1.Location = new System.Drawing.Point(44, 81);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(18, 18);
            this.player1.TabIndex = 14;
            // 
            // collisionWall1
            // 
            this.collisionWall1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collisionWall1.Location = new System.Drawing.Point(27, 61);
            this.collisionWall1.Name = "collisionWall1";
            this.collisionWall1.Size = new System.Drawing.Size(207, 10);
            this.collisionWall1.TabIndex = 19;
            // 
            // collisionWall4
            // 
            this.collisionWall4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collisionWall4.Location = new System.Drawing.Point(222, 61);
            this.collisionWall4.Name = "collisionWall4";
            this.collisionWall4.Size = new System.Drawing.Size(12, 116);
            this.collisionWall4.TabIndex = 20;
            // 
            // collisionWall5
            // 
            this.collisionWall5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collisionWall5.Location = new System.Drawing.Point(165, 111);
            this.collisionWall5.Name = "collisionWall5";
            this.collisionWall5.Size = new System.Drawing.Size(12, 116);
            this.collisionWall5.TabIndex = 21;
            // 
            // collisionWall6
            // 
            this.collisionWall6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collisionWall6.Location = new System.Drawing.Point(165, 217);
            this.collisionWall6.Name = "collisionWall6";
            this.collisionWall6.Size = new System.Drawing.Size(207, 10);
            this.collisionWall6.TabIndex = 22;
            // 
            // collisionWall7
            // 
            this.collisionWall7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.collisionWall7.Location = new System.Drawing.Point(222, 167);
            this.collisionWall7.Name = "collisionWall7";
            this.collisionWall7.Size = new System.Drawing.Size(207, 10);
            this.collisionWall7.TabIndex = 23;
            // 
            // frGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.collisionWall7);
            this.Controls.Add(this.collisionWall6);
            this.Controls.Add(this.collisionWall5);
            this.Controls.Add(this.collisionWall4);
            this.Controls.Add(this.collisionWall1);
            this.Controls.Add(this.collisionWall3);
            this.Controls.Add(this.collisionWall2);
            this.Controls.Add(this.movableCollisionWallV1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frGame";
            this.Text = "frGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer GameRoutine;
        private Player player1;
        private MovableCollisionWallV movableCollisionWallV1;
        private CollisionWall collisionWall2;
        private CollisionWall collisionWall3;
        private CollisionWall collisionWall1;
        private CollisionWall collisionWall4;
        private CollisionWall collisionWall5;
        private CollisionWall collisionWall6;
        private CollisionWall collisionWall7;
    }
}