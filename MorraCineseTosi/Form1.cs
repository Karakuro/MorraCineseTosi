using MorraCineseTosi.Properties;

namespace MorraCineseTosi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Stats = new Statistics();
        }

        private Statistics Stats { get; set; } = new Statistics();
        private Choice player1Choice;
        private Choice player2Choice;

        private void CartaBtn_Click(object sender, EventArgs e)
        {
            //if (Stats.Turn == Turn.Player1)
            //    message = "Giocatore 1 ha scelto CARTA";
            //else if (Stats.Turn == Turn.Player2)
            //    message = "Giocatore 2 ha scelto CARTA";

            CalculateResult(sender, e, Choice.Paper);
        }

        private void ForbiciBtn_Click(object sender, EventArgs e)
        {
            CalculateResult(sender, e, Choice.Scissors);
        }

        private void SassoBtn_Click(object sender, EventArgs e)
        {

            CalculateResult(sender, e, Choice.Rock);
        }

        private void CalculateResult(object sender, EventArgs e, Choice playerChoice)
        {
            Button? btn = sender as Button;

            if (btn != null)
            {
                StateLbl.Text = $"Giocatore {(int)Stats.Turn} ha scelto";
                if (!VersusPic.Visible)
                    VersusPic.Visible = true;

                Turn turn = Stats.Turn;
                Stats.NextTurn();
                if (turn == Turn.Player1)
                {
                    if (!PlayerChoicePic.Visible)
                        PlayerChoicePic.Visible = true;

                    PlayerChoicePic.Image = Resources.Scelta;
                    CpuChoicePic.Image = Resources.Scelta;
                    player1Choice = playerChoice;
                }
                else
                {
                    player2Choice = playerChoice;
                    CpuChoicePic.Image = btn.Image;

                    switch (player1Choice)
                    {
                        case Choice.Rock:
                            PlayerChoicePic.Image = Resources.Sasso;
                            break;
                        case Choice.Paper:
                            PlayerChoicePic.Image = Resources.Carta;
                            break;
                        case Choice.Scissors:
                            PlayerChoicePic.Image = Resources.Forbice;
                            break;
                    }

                    #region CPU
                    //Random rand = new Random();

                    //Choice cpuChoice = new Choice();

                    //switch(rand.Next(0,3))
                    //{
                    //    case 0:
                    //        cpuChoice = Choice.Rock;
                    //        break;
                    //    case 1:
                    //        cpuChoice = Choice.Paper;
                    //        break;
                    //    case 2:
                    //        cpuChoice = Choice.Scissors;
                    //        break;
                    //}

                    //cpuChoice = (Choice)rand.Next(0, 3);

                    //switch (cpuChoice)
                    //{
                    //    case Choice.Rock:
                    //        CpuChoicePic.Image = Resources.Sasso;
                    //        break;
                    //    case Choice.Paper:
                    //        CpuChoicePic.Image = Resources.Carta;
                    //        break;
                    //    case Choice.Scissors:
                    //        CpuChoicePic.Image = Resources.Forbice;
                    //        break;
                    //}
                    #endregion

                    if (player1Choice == player2Choice)
                    {
                        ResultLbl.Text = "PAREGGIO";
                        Stats.Draws++;

                    }
                    else if (player1Choice == Choice.Rock && player2Choice == Choice.Scissors
                        || player1Choice == Choice.Paper && player2Choice == Choice.Rock
                        || player1Choice == Choice.Scissors && player2Choice == Choice.Paper)
                    {
                        ResultLbl.Text = "Giocatore 1 vince!";
                        Stats.Player1Wins++;
                    }
                    else
                    {
                        ResultLbl.Text = "Giocatore 2 vince!";
                        Stats.Player2Wins++;
                    }

                    //string testo = $"Il totale delle vittorie del giocatore è: {Stats.PlayerWins}";
                    playerWinsLbl.Text = $"{Stats.Player1Wins}";
                    cpuWinsLbl.Text = $"{Stats.Player2Wins}";
                    drawsLbl.Text = Stats.Draws.ToString();
                }
            }
        }

        private enum Choice
        {
            Rock,
            Paper,
            Scissors
        }


    }
}