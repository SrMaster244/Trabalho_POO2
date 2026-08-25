namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.topLeft = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.topRight = new System.Windows.Forms.PictureBox();
            this.goalKeeper = new System.Windows.Forms.PictureBox();
            this.football = new System.Windows.Forms.PictureBox();
            this.KeeperTimer = new System.Windows.Forms.Timer(this.components);
            this.BallTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(13, 8);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(126, 40);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.BackColor = System.Drawing.Color.Transparent;
            this.lblMissed.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissed.ForeColor = System.Drawing.Color.White;
            this.lblMissed.Location = new System.Drawing.Point(743, 9);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(146, 40);
            this.lblMissed.TabIndex = 1;
            this.lblMissed.Text = "Missed: 0";
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Yellow;
            this.left.Image = global::Football_Pentalty_Shootout_Game_MOO_ICT.Properties.Resources.target;
            this.left.Location = new System.Drawing.Point(201, 238);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(40, 40);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.left.TabIndex = 2;
            this.left.TabStop = false;
            this.left.Tag = "left";
            this.left.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Yellow;
            this.right.Image = global::Football_Pentalty_Shootout_Game_MOO_ICT.Properties.Resources.target;
            this.right.Location = new System.Drawing.Point(675, 238);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(40, 40);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.right.TabIndex = 3;
            this.right.TabStop = false;
            this.right.Tag = "right";
            this.right.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // topLeft
            // 
            this.topLeft.BackColor = System.Drawing.Color.Yellow;
            this.topLeft.Image = global::Football_Pentalty_Shootout_Game_MOO_ICT.Properties.Resources.target;
            this.topLeft.Location = new System.Drawing.Point(201, 78);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(40, 40);
            this.topLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topLeft.TabIndex = 4;
            this.topLeft.TabStop = false;
            this.topLeft.Tag = "topLeft";
            this.topLeft.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Yellow;
            this.top.Image = global::Football_Pentalty_Shootout_Game_MOO_ICT.Properties.Resources.target;
            this.top.Location = new System.Drawing.Point(437, 76);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(40, 40);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 5;
            this.top.TabStop = false;
            this.top.Tag = "top";
            this.top.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.Yellow;
            this.topRight.Image = global::Football_Pentalty_Shootout_Game_MOO_ICT.Properties.Resources.target;
            this.topRight.Location = new System.Drawing.Point(675, 76);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(40, 40);
            this.topRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topRight.TabIndex = 6;
            this.topRight.TabStop = false;
            this.topRight.Tag = "topRight";
            this.topRight.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // goalKeeper
            // 
            this.goalKeeper.BackColor = System.Drawing.Color.Transparent;
            this.goalKeeper.Image = global::Football_Pentalty_Shootout_Game_MOO_ICT.Properties.Resources.stand_small;
            this.goalKeeper.Location = new System.Drawing.Point(418, 169);
            this.goalKeeper.Name = "goalKeeper";
            this.goalKeeper.Size = new System.Drawing.Size(82, 126);
            this.goalKeeper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goalKeeper.TabIndex = 7;
            this.goalKeeper.TabStop = false;
            // 
            // football
            // 
            this.football.BackColor = System.Drawing.Color.Transparent;
            this.football.Image = global::Football_Pentalty_Shootout_Game_MOO_ICT.Properties.Resources.football;
            this.football.Location = new System.Drawing.Point(430, 500);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(50, 51);
            this.football.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.football.TabIndex = 8;
            this.football.TabStop = false;
            // 
            // KeeperTimer
            // 
            this.KeeperTimer.Interval = 20;
            this.KeeperTimer.Tick += new System.EventHandler(this.KeeperTimerEvent);
            // 
            // BallTimer
            // 
            this.BallTimer.Interval = 20;
            this.BallTimer.Tick += new System.EventHandler(this.BallTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Football_Pentalty_Shootout_Game_MOO_ICT.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 678);
            this.Controls.Add(this.football);
            this.Controls.Add(this.goalKeeper);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.top);
            this.Controls.Add(this.topLeft);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.lblScore);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Football Penalty Shootout Game MOOICT";
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblScore;
        private Label lblMissed;
        private PictureBox left;
        private PictureBox right;
        private PictureBox topLeft;
        private PictureBox top;
        private PictureBox topRight;
        private PictureBox goalKeeper;
        private PictureBox football;
        private System.Windows.Forms.Timer KeeperTimer;
        private System.Windows.Forms.Timer BallTimer;
    }
}