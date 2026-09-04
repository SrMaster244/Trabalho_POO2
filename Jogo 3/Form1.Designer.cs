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
            components = new System.ComponentModel.Container();
            lblMissed = new Label();
            left = new PictureBox();
            right = new PictureBox();
            topLeft = new PictureBox();
            top = new PictureBox();
            topRight = new PictureBox();
            goalKeeper = new PictureBox();
            football = new PictureBox();
            KeeperTimer = new System.Windows.Forms.Timer(components);
            BallTimer = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            IniciarJogo = new Button();
            FotoDesfoque = new PictureBox();
            pontuacaoText = new Label();
            PontuacaoNum = new Label();
            ResetButton1 = new Button();
            ResetPerdeu = new Button();
            MensagemPerdeu = new Button();
            PontuacaoMax = new Button();
            Op1 = new Button();
            Op2 = new Button();
            Op3 = new Button();
            PainelDificuldade = new Button();
            NumDif = new Button();
            VidasText = new Label();
            ((System.ComponentModel.ISupportInitialize)left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalKeeper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)football).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FotoDesfoque).BeginInit();
            SuspendLayout();
            // 
            // lblMissed
            // 
            lblMissed.AutoSize = true;
            lblMissed.BackColor = Color.Transparent;
            lblMissed.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblMissed.ForeColor = Color.White;
            lblMissed.Location = new Point(728, 9);
            lblMissed.Name = "lblMissed";
            lblMissed.Size = new Size(157, 40);
            lblMissed.TabIndex = 1;
            lblMissed.Text = "Perdido: 0";
            lblMissed.Click += lblMissed_Click;
            // 
            // left
            // 
            left.BackColor = Color.Yellow;
            left.Image = Properties.Resources.target;
            left.Location = new Point(201, 238);
            left.Name = "left";
            left.Size = new Size(40, 40);
            left.SizeMode = PictureBoxSizeMode.StretchImage;
            left.TabIndex = 2;
            left.TabStop = false;
            left.Tag = "left";
            left.Visible = false;
            left.Click += SetGoalTargetEvent;
            // 
            // right
            // 
            right.BackColor = Color.Yellow;
            right.Image = Properties.Resources.target;
            right.Location = new Point(675, 238);
            right.Name = "right";
            right.Size = new Size(40, 40);
            right.SizeMode = PictureBoxSizeMode.StretchImage;
            right.TabIndex = 3;
            right.TabStop = false;
            right.Tag = "right";
            right.Visible = false;
            right.Click += SetGoalTargetEvent;
            // 
            // topLeft
            // 
            topLeft.BackColor = Color.Yellow;
            topLeft.Image = Properties.Resources.target;
            topLeft.Location = new Point(201, 78);
            topLeft.Name = "topLeft";
            topLeft.Size = new Size(40, 40);
            topLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            topLeft.TabIndex = 4;
            topLeft.TabStop = false;
            topLeft.Tag = "topLeft";
            topLeft.Visible = false;
            topLeft.Click += SetGoalTargetEvent;
            // 
            // top
            // 
            top.BackColor = Color.Yellow;
            top.Image = Properties.Resources.target;
            top.Location = new Point(437, 76);
            top.Name = "top";
            top.Size = new Size(40, 40);
            top.SizeMode = PictureBoxSizeMode.StretchImage;
            top.TabIndex = 5;
            top.TabStop = false;
            top.Tag = "top";
            top.Visible = false;
            top.Click += SetGoalTargetEvent;
            // 
            // topRight
            // 
            topRight.BackColor = Color.Yellow;
            topRight.Image = Properties.Resources.target;
            topRight.Location = new Point(675, 76);
            topRight.Name = "topRight";
            topRight.Size = new Size(40, 40);
            topRight.SizeMode = PictureBoxSizeMode.StretchImage;
            topRight.TabIndex = 6;
            topRight.TabStop = false;
            topRight.Tag = "topRight";
            topRight.Visible = false;
            topRight.Click += SetGoalTargetEvent;
            // 
            // goalKeeper
            // 
            goalKeeper.BackColor = Color.Transparent;
            goalKeeper.Image = Properties.Resources.stand_small;
            goalKeeper.Location = new Point(418, 169);
            goalKeeper.Name = "goalKeeper";
            goalKeeper.Size = new Size(82, 126);
            goalKeeper.SizeMode = PictureBoxSizeMode.AutoSize;
            goalKeeper.TabIndex = 7;
            goalKeeper.TabStop = false;
            // 
            // football
            // 
            football.BackColor = Color.Transparent;
            football.Image = Properties.Resources.football;
            football.Location = new Point(430, 500);
            football.Name = "football";
            football.Size = new Size(50, 51);
            football.SizeMode = PictureBoxSizeMode.AutoSize;
            football.TabIndex = 8;
            football.TabStop = false;
            football.Visible = false;
            // 
            // KeeperTimer
            // 
            KeeperTimer.Interval = 20;
            KeeperTimer.Tick += KeeperTimerEvent;
            // 
            // BallTimer
            // 
            BallTimer.Interval = 20;
            BallTimer.Tick += BallTimerEvent;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // IniciarJogo
            // 
            IniciarJogo.BackColor = Color.CornflowerBlue;
            IniciarJogo.BackgroundImageLayout = ImageLayout.Center;
            IniciarJogo.FlatStyle = FlatStyle.Flat;
            IniciarJogo.Font = new Font("ROG Fonts", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IniciarJogo.ForeColor = SystemColors.ControlText;
            IniciarJogo.Location = new Point(304, 409);
            IniciarJogo.Name = "IniciarJogo";
            IniciarJogo.Size = new Size(311, 70);
            IniciarJogo.TabIndex = 9;
            IniciarJogo.Text = "INICIAR JOGO";
            IniciarJogo.UseVisualStyleBackColor = false;
            IniciarJogo.Click += button1_Click;
            // 
            // FotoDesfoque
            // 
            FotoDesfoque.BackgroundImage = Properties.Resources.background_desfocado;
            FotoDesfoque.Location = new Point(0, 0);
            FotoDesfoque.Name = "FotoDesfoque";
            FotoDesfoque.Size = new Size(954, 747);
            FotoDesfoque.TabIndex = 10;
            FotoDesfoque.TabStop = false;
            FotoDesfoque.Click += pictureBox1_Click;
            // 
            // pontuacaoText
            // 
            pontuacaoText.AutoSize = true;
            pontuacaoText.BackColor = Color.Transparent;
            pontuacaoText.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            pontuacaoText.ForeColor = Color.White;
            pontuacaoText.Location = new Point(12, 9);
            pontuacaoText.Name = "pontuacaoText";
            pontuacaoText.Size = new Size(205, 40);
            pontuacaoText.TabIndex = 11;
            pontuacaoText.Text = "PONTUAÇÃO:";
            pontuacaoText.Click += label1_Click_2;
            // 
            // PontuacaoNum
            // 
            PontuacaoNum.AutoSize = true;
            PontuacaoNum.BackColor = Color.Transparent;
            PontuacaoNum.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            PontuacaoNum.ForeColor = Color.White;
            PontuacaoNum.Location = new Point(207, 9);
            PontuacaoNum.Name = "PontuacaoNum";
            PontuacaoNum.Size = new Size(34, 40);
            PontuacaoNum.TabIndex = 12;
            PontuacaoNum.Text = "0";
            // 
            // ResetButton1
            // 
            ResetButton1.BackColor = Color.FromArgb(192, 0, 0);
            ResetButton1.BackgroundImageLayout = ImageLayout.Center;
            ResetButton1.FlatAppearance.BorderSize = 0;
            ResetButton1.ForeColor = Color.White;
            ResetButton1.Location = new Point(755, 52);
            ResetButton1.Name = "ResetButton1";
            ResetButton1.RightToLeft = RightToLeft.No;
            ResetButton1.Size = new Size(95, 31);
            ResetButton1.TabIndex = 13;
            ResetButton1.Text = "RESET";
            ResetButton1.UseVisualStyleBackColor = false;
            ResetButton1.Visible = false;
            ResetButton1.Click += ResetButton1_Click;
            // 
            // ResetPerdeu
            // 
            ResetPerdeu.BackColor = Color.FromArgb(192, 0, 0);
            ResetPerdeu.BackgroundImageLayout = ImageLayout.Center;
            ResetPerdeu.FlatAppearance.BorderSize = 0;
            ResetPerdeu.ForeColor = Color.White;
            ResetPerdeu.Location = new Point(405, 376);
            ResetPerdeu.Name = "ResetPerdeu";
            ResetPerdeu.RightToLeft = RightToLeft.No;
            ResetPerdeu.Size = new Size(95, 31);
            ResetPerdeu.TabIndex = 14;
            ResetPerdeu.Text = "RESET";
            ResetPerdeu.UseVisualStyleBackColor = false;
            ResetPerdeu.Visible = false;
            ResetPerdeu.Click += ResetPerdeu_Click;
            // 
            // MensagemPerdeu
            // 
            MensagemPerdeu.BackColor = Color.Red;
            MensagemPerdeu.BackgroundImageLayout = ImageLayout.Center;
            MensagemPerdeu.FlatStyle = FlatStyle.Flat;
            MensagemPerdeu.Font = new Font("ROG Fonts", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MensagemPerdeu.ForeColor = Color.Yellow;
            MensagemPerdeu.Location = new Point(241, 312);
            MensagemPerdeu.Name = "MensagemPerdeu";
            MensagemPerdeu.Size = new Size(443, 58);
            MensagemPerdeu.TabIndex = 15;
            MensagemPerdeu.Text = "JOGO ENCERRADO!";
            MensagemPerdeu.UseVisualStyleBackColor = false;
            MensagemPerdeu.Visible = false;
            MensagemPerdeu.Click += MensagemPerdeu_Click;
            // 
            // PontuacaoMax
            // 
            PontuacaoMax.BackColor = Color.Red;
            PontuacaoMax.BackgroundImageLayout = ImageLayout.Center;
            PontuacaoMax.FlatStyle = FlatStyle.Flat;
            PontuacaoMax.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PontuacaoMax.ForeColor = Color.White;
            PontuacaoMax.Location = new Point(242, 105);
            PontuacaoMax.Name = "PontuacaoMax";
            PontuacaoMax.Size = new Size(473, 58);
            PontuacaoMax.TabIndex = 16;
            PontuacaoMax.Text = "PONTUAÇÃO MÁXIMA: 0";
            PontuacaoMax.TextAlign = ContentAlignment.MiddleLeft;
            PontuacaoMax.UseVisualStyleBackColor = false;
            PontuacaoMax.Visible = false;
            // 
            // Op1
            // 
            Op1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Op1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Op1.Location = new Point(350, 255);
            Op1.Name = "Op1";
            Op1.Size = new Size(43, 40);
            Op1.TabIndex = 17;
            Op1.Text = "1";
            Op1.UseVisualStyleBackColor = true;
            Op1.Click += button2_Click;
            // 
            // Op2
            // 
            Op2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Op2.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Op2.Location = new Point(437, 255);
            Op2.Name = "Op2";
            Op2.Size = new Size(43, 40);
            Op2.TabIndex = 18;
            Op2.Text = "2";
            Op2.UseVisualStyleBackColor = true;
            Op2.Click += Op2_Click;
            // 
            // Op3
            // 
            Op3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Op3.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Op3.Location = new Point(523, 255);
            Op3.Name = "Op3";
            Op3.Size = new Size(43, 40);
            Op3.TabIndex = 19;
            Op3.Text = "3";
            Op3.UseVisualStyleBackColor = true;
            Op3.Click += Op3_Click;
            // 
            // PainelDificuldade
            // 
            PainelDificuldade.BackColor = Color.CornflowerBlue;
            PainelDificuldade.BackgroundImageLayout = ImageLayout.Center;
            PainelDificuldade.FlatStyle = FlatStyle.Flat;
            PainelDificuldade.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PainelDificuldade.ForeColor = Color.Black;
            PainelDificuldade.Location = new Point(247, 191);
            PainelDificuldade.Name = "PainelDificuldade";
            PainelDificuldade.Size = new Size(443, 58);
            PainelDificuldade.TabIndex = 20;
            PainelDificuldade.Text = "DIFICULDADE";
            PainelDificuldade.UseVisualStyleBackColor = false;
            PainelDificuldade.Click += button4_Click;
            // 
            // NumDif
            // 
            NumDif.BackColor = Color.CornflowerBlue;
            NumDif.BackgroundImageLayout = ImageLayout.Center;
            NumDif.FlatStyle = FlatStyle.Flat;
            NumDif.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumDif.ForeColor = Color.Black;
            NumDif.Location = new Point(647, 255);
            NumDif.Name = "NumDif";
            NumDif.Size = new Size(43, 42);
            NumDif.TabIndex = 21;
            NumDif.Text = "1";
            NumDif.UseVisualStyleBackColor = false;
            // 
            // VidasText
            // 
            VidasText.AutoSize = true;
            VidasText.BackColor = Color.Transparent;
            VidasText.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            VidasText.ForeColor = Color.White;
            VidasText.Location = new Point(12, 43);
            VidasText.Name = "VidasText";
            VidasText.Size = new Size(110, 40);
            VidasText.TabIndex = 22;
            VidasText.Text = "VIDAS:";
            VidasText.Visible = false;
            VidasText.Click += label1_Click_4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(899, 678);
            Controls.Add(VidasText);
            Controls.Add(NumDif);
            Controls.Add(PainelDificuldade);
            Controls.Add(Op3);
            Controls.Add(Op2);
            Controls.Add(Op1);
            Controls.Add(PontuacaoMax);
            Controls.Add(MensagemPerdeu);
            Controls.Add(ResetPerdeu);
            Controls.Add(ResetButton1);
            Controls.Add(PontuacaoNum);
            Controls.Add(pontuacaoText);
            Controls.Add(IniciarJogo);
            Controls.Add(FotoDesfoque);
            Controls.Add(football);
            Controls.Add(goalKeeper);
            Controls.Add(topRight);
            Controls.Add(top);
            Controls.Add(topLeft);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(lblMissed);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Football Penalty Shootout Game MOOICT";
            ((System.ComponentModel.ISupportInitialize)left).EndInit();
            ((System.ComponentModel.ISupportInitialize)right).EndInit();
            ((System.ComponentModel.ISupportInitialize)topLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)top).EndInit();
            ((System.ComponentModel.ISupportInitialize)topRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalKeeper).EndInit();
            ((System.ComponentModel.ISupportInitialize)football).EndInit();
            ((System.ComponentModel.ISupportInitialize)FotoDesfoque).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Timer timer1;
        private Button IniciarJogo;
        private PictureBox FotoDesfoque;
        private Label pontuacaoText;
        private Label PontuacaoNum;
        private Button ResetButton1;
        private Button ResetPerdeu;
        private Button MensagemPerdeu;
        private Button PontuacaoMax;
        private Button Op1;
        private Button Op2;
        private Button Op3;
        private Button PainelDificuldade;
        private Button NumDif;
        private Label VidasText;
    }
}