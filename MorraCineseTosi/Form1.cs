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

        private void CartaBtn_Click(object sender, EventArgs e)
        {
            ResultLbl.Text = "Hai scelto CARTA";
            CalculateResult(sender, e, Choice.Paper);
        }

        private void ForbiciBtn_Click(object sender, EventArgs e)
        {
            ResultLbl.Text = "Hai scelto FORBICI";
            CalculateResult(sender, e, Choice.Scissors);
        }

        private void SassoBtn_Click(object sender, EventArgs e)
        {
            ResultLbl.Text = "Hai scelto SASSO";
            CalculateResult(sender, e, Choice.Rock);
        }

        private void CalculateResult(object sender, EventArgs e, Choice playerChoice)
        {
            Button? btn = sender as Button;

            if (btn != null)
            {
                PlayerChoicePic.Image = btn.Image;

                Random rand = new Random();

                Choice cpuChoice = new Choice();

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

                cpuChoice = (Choice)rand.Next(0, 3);

                switch (cpuChoice)
                {
                    case Choice.Rock:
                        CpuChoicePic.Image = Resources.Sasso;
                        break;
                    case Choice.Paper:
                        CpuChoicePic.Image = Resources.Carta;
                        break;
                    case Choice.Scissors:
                        CpuChoicePic.Image = Resources.Forbice;
                        break;
                }

                VersusPic.Visible = true;

                if (playerChoice == cpuChoice)
                {
                    ResultLbl.Text = "PAREGGIO";
                    Stats.Draws++;

                }
                else if (playerChoice == Choice.Rock && cpuChoice == Choice.Scissors
                    || playerChoice == Choice.Paper && cpuChoice == Choice.Rock
                    || playerChoice == Choice.Scissors && cpuChoice == Choice.Paper)
                {
                    ResultLbl.Text = "Giocatore vince!";
                    Stats.PlayerWins++;
                }
                else
                {
                    ResultLbl.Text = "CPU vince!";
                    Stats.CpuWins++;
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