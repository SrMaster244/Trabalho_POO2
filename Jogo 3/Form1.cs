namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    // Made by MOO ICT
    // For educational purpose only
    public partial class Form1 : Form
    {

        List<string> KeeperPosition = new List<string> { "left", "right", "top", "topLeft", "topRight"};//LISTA DE POSIÇÕES QUE O GOLEIRO PODE PULAR PARA TENTAR DEFENDER O CHUTE DO JOGADOR
        List<PictureBox> goalTarget;
        int ballX = 0;
        int ballY = 0;
        int goal = 0;
        int miss = 0;
        string state; //posição escolhiada pelo goleiro 
        string playerTarget; //GUARDA O LOCAL ESCOLHIDO PELO JOGADOR PARA CHUTAR A BOLA
        bool aimSet = false; //SE O JOGADOR JÁ ESCOLHEU A POSIÇÃO PARA CHUTAR A BOLA
        Random random = new Random();//GOLEIRO PULA PARA UM LADO ALEATÓRIO PARA TENTAR DEFENDER O CHUTE DO JOGADOR

        public Form1()
        {
            InitializeComponent();
            goalTarget = new List<PictureBox> { left, right, top, topLeft, topRight}; //AQUI INICIALIZAMOS A LISTA DE POSIÇÕES QUE O JOGADOR PODE CHUTAR A BOLA
        }

        private void SetGoalTargetEvent(object sender, EventArgs e) //CONECTADO AO PICTUREBOXES, QUANDO CLICA EM UMA REGIÃO DO GOL O MÉTODO É EXECUTADO
        {
            if (aimSet == true) { return; } //SE O JOGADOR JÁ ESCOLHEU A POSIÇÃO PARA CHUTAR A BOLA, NÃO PODE MAIS MUDAR

            BallTimer.Start();
            KeeperTimer.Start();
            ChangeGoalKeeperImage();    

            var senderObject = (PictureBox)sender; //PEGA O OBJETO QUE DISPAROU O EVENTO E TRANSFORMA EM PICTUREBOX
            senderObject.BackColor = Color.Beige; //MUDA A COR DA REGIÃO SELECIONADA 

            if (senderObject.Tag.ToString() == "topRight")
            {
                ballX = -7;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString(); //AQUI GUARDA A ESCOLHA DO JOGADOR 
                aimSet = true; //BLOQUEIA NOVA ESCOLHA 
            }
            if (senderObject.Tag.ToString() == "right")
            {
                ballX = -11;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "top")
            {
                ballX = 0;
                ballY = 20;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "topLeft")
            {
                ballX = 8;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }
            if (senderObject.Tag.ToString() == "left")
            {
                ballX = 7;
                ballY = 8;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
            }

            CheckScore();

        }

        private void KeeperTimerEvent(object sender, EventArgs e) //VERIFICA QUAL POSIÇÃO FOI SORTEADA 
        {
            switch (state)
            {

                case "left":
                    goalKeeper.Left -= 6;
                    goalKeeper.Top = 204;
                    break;
                case "right":
                    goalKeeper.Left += 6;
                    goalKeeper.Top = 204;
                    break;
                case "top":
                    goalKeeper.Top -= 6;
                    break;
                case "topLeft":
                    goalKeeper.Left -= 6;
                    goalKeeper.Top -= 3;
                    break;
                case "topRight":
                    goalKeeper.Left += 6;
                    goalKeeper.Top -= 3;
                    break;
            }

            foreach (PictureBox x  in goalTarget)
            {
                if (goalKeeper.Bounds.IntersectsWith(x.Bounds))
                {

                    KeeperTimer.Stop();
                    goalKeeper.Location = new Point(418, 169);
                    goalKeeper.Image = Properties.Resources.stand_small;

                }
            }


        }

        private void BallTimerEvent(object sender, EventArgs e)
        {
            football.Left -= ballX;
            football.Top -= ballY;

            foreach (PictureBox x  in goalTarget)
            {
                if (football.Bounds.IntersectsWith(x.Bounds))
                {

                    football.Location = new Point(430, 500);
                    ballX = 0;
                    ballY = 0;
                    aimSet = false;
                    BallTimer.Stop();
                }
            }


        }

        private void CheckScore()
        {
            if (state == playerTarget)
            {
                miss++;
                lblMissed.Text = "Missed: " + miss;
            }
            else
            {
                goal++;
                lblScore.Text = "Scored: " + goal;
            }
        }

        private void ChangeGoalKeeperImage()
        {
            KeeperTimer.Start();
            int i = random.Next(0, KeeperPosition.Count);
            state = KeeperPosition[i];

            switch (i)
            {
                case 0:
                    goalKeeper.Image = Properties.Resources.left_save_small;
                    break;
                case 1:
                    goalKeeper.Image = Properties.Resources.right_save_small;
                    break;
                case 2:
                    goalKeeper.Image = Properties.Resources.top_save_small;
                    break;
                case 3:
                    goalKeeper.Image = Properties.Resources.top_left_save_small;
                    break;
                case 4:
                    goalKeeper.Image = Properties.Resources.top_right_save_small;
                    break;
            }
        }

    }
}
