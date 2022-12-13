using System.Windows.Forms.Automation;

namespace WinFormsApp1
{
    public partial class frmCoinToss : Form
    {
        Random random = new Random();
        bool playing = false;
        bool roundOn = false;
        int toss;
        int yourGuess;
        int teller;
        int lives;
        int score;
        String mediumString = "";

        public frmCoinToss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playing)
            {

            }
            else
            {
                if (nightmareToggle.Checked)
                {
                    lives = 1;
                }
                else
                {
                    lives = 3;
                }
                playing = true;
                lblLives.Text = "lives: " + lives;
                btnGO.Text = "Give up";
                NewRound();
            }
        }

        

        public void NewRound()
        {
            lblMedium.Text = "Heads or tails";
            toss = random.Next(0,2);
            roundOn = true;
            teller = 0;
            mediumString = "";
        }

        private void highscoresnightmareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnHeads_Click(object sender, EventArgs e)
        {
            if (playing && roundOn)
            {
                yourGuess = 0;
                timer1.Enabled = true;
                roundOn = false;
            }
        }
        private void btnTails_Click(object sender, EventArgs e)
        {
            if (playing && roundOn)
            {
                yourGuess = 1;
                timer1.Enabled = true;
                roundOn = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (teller < 3)
            {
                mediumString += ".";
                lblMedium.Text = mediumString;
            }
            else if (3 < teller && teller < 5)
            {
                if (toss == 0)
                {
                    lblMedium.Text = "It's Heads!";
                }
                else if (toss == 1)
                {
                    lblMedium.Text = "It's Tails";
                }
            }
            else if (5 < teller && teller < 7)
            {
                if (toss == yourGuess)
                {
                    lblMedium.Text = "Good job guessing.";
                    score += 1;
                } 
                else
                {
                    lblMedium.Text = "Wrong guess";
                    lives = lives - 1;
                    lblLives.Text = "lives: " + lives;
                }
            }
            else if (teller > 7)
            {
                if (lives > 0)
                {
                    NewRound();
                    timer1.Enabled = false;
                }
                else
                {
                    playing = false;
                    btnGO.Text = "GO";
                    lblMedium.Text = "COIN TOSS";
                    
                    //highscore check

                    timer1.Enabled = false;
                    MessageBox.Show("Your score: " + score, "Nice attempt", MessageBoxButtons.OK);
                }
            }
            teller += 1;
        }

        
    }
}