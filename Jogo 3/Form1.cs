using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Football_Pentalty_Shootout_Game_MOO_ICT
{
    // Made by MOO ICT
    // For educational purpose only
    public partial class Form1 : Form
    {

        List<string> KeeperPosition = new List<string> { "left", "right", "top", "topLeft", "topRight" };//LISTA DE POSIÇÕES QUE O GOLEIRO PODE PULAR PARA TENTAR DEFENDER O CHUTE DO JOGADOR
        List<PictureBox> goalTarget;
        int ballX = 0;
        int ballY = 0;
        int goal = 0;
        int miss = 0;
        int EscolhaPlayer;
        int NivelDificuldade = 1; // Nível de dificuldade escolhido pelo jogador. Vai de 1 a 3.
        int VidasPlayer = 6;
        float multiplicador = 1;
        float pontuacaofinal = 0;
        bool JogoComeçou = false;
        string state; //posição escolhiada pelo goleiro 
        string playerTarget; //GUARDA O LOCAL ESCOLHIDO PELO JOGADOR PARA CHUTAR A BOLA
        bool aimSet = false; //SE O JOGADOR JÁ ESCOLHEU A POSIÇÃO PARA CHUTAR A BOLA


        Random random = new Random();//GOLEIRO PULA PARA UM LADO ALEATÓRIO PARA TENTAR DEFENDER O CHUTE DO JOGADOR

        public Form1()
        {
            InitializeComponent();
            goalTarget = new List<PictureBox> { left, right, top, topLeft, topRight }; //AQUI INICIALIZAMOS A LISTA DE POSIÇÕES QUE O JOGADOR PODE CHUTAR A BOLA
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
                EscolhaPlayer = 4;
            }
            if (senderObject.Tag.ToString() == "right")
            {
                ballX = -11;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
                EscolhaPlayer = 1;
            }
            if (senderObject.Tag.ToString() == "top")
            {
                ballX = 0;
                ballY = 20;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
                EscolhaPlayer = 2;
            }
            if (senderObject.Tag.ToString() == "topLeft")
            {
                ballX = 8;
                ballY = 15;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
                EscolhaPlayer = 3;
            }
            if (senderObject.Tag.ToString() == "left")
            {
                ballX = 7;
                ballY = 8;
                playerTarget = senderObject.Tag.ToString();
                aimSet = true;
                EscolhaPlayer = 0;
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

            foreach (PictureBox x in goalTarget)
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

            foreach (PictureBox x in goalTarget)
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
                lblMissed.Text = "Perdido: " + miss;
                VidasPlayer--;
                VidasText.Text = "VIDAS: " + VidasPlayer;

                if (VidasPlayer < 1)
                {
                    Invisivel(false, 2);
                    MensagemPerdeu.Visible = true;
                    ResetPerdeu.Visible = true;                                                           
                }
            }
            else
            {
                goal++;
                PontuacaoNum.Text = goal.ToString();
            }
        }

        private void vidas()
        {
            switch (NivelDificuldade)
            {
                case 2:
                    VidasPlayer = 4;
                    break;
                case 3:
                    VidasPlayer = 2;
                    break;
                default:
                    VidasPlayer = 6;
                    break;
            }
        }

        private int Dificuldade(int opcao)
        {
            switch (NivelDificuldade)
            {
                case 2:
                    multiplicador = 1.5f;
                    break;
                case 3:
                    multiplicador = 3.5f;
                    break;
                default:
                    break;
            }
            Random rnd = new Random();
            if (rnd.Next(0, 5 - opcao) == 0)
            {
                return EscolhaPlayer;
            }
            else return rnd.Next(1, 4);
        }


        private void ChangeGoalKeeperImage() // troca a imagem do goleiro conforme a posição de defesa
        {
            KeeperTimer.Start();
            int i = Dificuldade(NivelDificuldade);
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

        private void EndGame()
        {
            MaiorPontuacao(goal * multiplicador);
            pontuacaofinal = goal * multiplicador;
            JogoComeçou = false;
            PontuacaoNum.Text = pontuacaofinal.ToString();
            lblMissed.Text = "Perdido: 0";
            Invisivel(true, 1);
            Invisivel(false, 2);
           
            goal = 0;
            miss = 0;

        }
        private void MaiorPontuacao(float pontuacao)
        {
            if (pontuacao > pontuacaofinal)
            {
                PontuacaoMax.Text = "PONTUAÇÃO MÁXIMA = " + pontuacao.ToString("F2");
            }
            PontuacaoMax.Visible = true;

        }
        private void Invisivel(bool visivel, int opcao) // Opção refere-se a ser: [1] Elementos do HUD pré jogo (botão iniciar, etc.), [2]: Elementos de gameplay (bola, escolhas)
        {
            if (opcao == 1)
            {
                IniciarJogo.Visible = visivel;
                FotoDesfoque.Visible = visivel;
                PontuacaoMax.Visible = visivel;
                Op1.Visible = visivel;
                Op2.Visible = visivel;
                Op3.Visible = visivel;
                NumDif.Visible = visivel;
                PainelDificuldade.Visible = visivel;

            }
            else
            {
                top.Visible = visivel;
                topLeft.Visible = visivel;
                topRight.Visible = visivel;
                right.Visible = visivel;
                left.Visible = visivel;
                football.Visible = visivel;
                ResetButton1.Visible = visivel;
                VidasText.Visible = visivel;
            }

        }

        // ----------------------------------------- OBJETOS DA INTERFACE ---------------------------------------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JogoComeçou = true;

            Invisivel(true, 2);
            Invisivel(false, 1);

            vidas();
            VidasText.Text = "VIDAS: " + VidasPlayer;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMissed_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ResetButton1_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void MensagemPerdeu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NivelDificuldade = 1;
            NumDif.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Op3_Click(object sender, EventArgs e)
        {
            NivelDificuldade = 3;
            NumDif.Text = "3";
        }

        private void Op2_Click(object sender, EventArgs e)
        {
            NivelDificuldade = 2;
            NumDif.Text = "2";
        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void ResetPerdeu_Click(object sender, EventArgs e)
        {
            EndGame(); 
            ResetPerdeu.Visible = false;
            MensagemPerdeu.Visible = false;
        }
    }
}
