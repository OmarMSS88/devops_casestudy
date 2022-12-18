using System.Windows.Forms.Automation;
using CoinToss;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
using System.Media;

namespace WinFormsApp1
{
    public partial class frmCoinToss : Form
    {
        Random random = new Random();
        bool playing = false;
        bool roundOn = false;
        bool nightmare;
        bool correct;
        int toss;
        int yourGuess;
        int teller;
        int lives;
        int score;
        String mediumString = "";
        String init;

        public frmCoinToss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                playing = false;
                correct = false;
                init = "";
                score = 0;
                lblLives.Text = "lives: ";
                btnGO.Text = "GO";
                lblMedium.Text = "COIN TOSS";
            }
            else
            {
                if (nightmareToggle.Checked)
                {
                    lives = 1;
                    nightmare = true;
                }
                else
                {
                    lives = 3;
                    nightmare = false;
                }
                playing = true;
                correct = false;
                init = "";
                score = 0;
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
                    timer1.Enabled = false;
                    //highscore check
                    using (UserDataContext HS = new UserDataContext())
                    {
                        if (nightmare)
                        {
                            if (HS.highscoresN.Any(player => player.score < this.score) || HS.highscoresN.Count() < 5)
                            {
                                
                                    init = Interaction.InputBox("Your initials (3 characters)","NEW HIGHSCORE");
                                    if(init.Length == 3)
                                    {
                                        correct = true;
                                    }
                                    if (correct) { 
                                HS.highscoresN.Add(new highscoreN() {initials = init, score = this.score});
                                HS.SaveChanges();
                                if (HS.highscoresN.Count() > 5)
                                {
                                    var HS1 = HS.highscoresN.OrderBy(b => b.score).First();
                                    HS.Remove(HS1);
                                    HS.SaveChanges();
                                }
                                }
                            }
                        }
                        else
                        {
                            if (HS.highscores.Any(player => player.score < this.score) || HS.highscores.Count() < 5)
                            {

                                init = Interaction.InputBox("Your initials (3 characters)", "NEW HIGHSCORE");
                                if (init.Length == 3)
                                {
                                    correct = true;
                                }
                                if (correct)
                                {
                                    HS.highscores.Add(new highscore() { initials = init, score = this.score });
                                    HS.SaveChanges();
                                    if (HS.highscores.Count() > 5)
                                    {
                                        var HS1 = HS.highscores.OrderBy(b => b.score).First();
                                        HS.Remove(HS1);
                                        HS.SaveChanges();
                                    }
                                }
                            }
                        }
                    }

                    
                    MessageBox.Show("Your score: " + score, "Nice attempt", MessageBoxButtons.OK);
                }
            }
            teller += 1;
        }

        private void frmCoinToss_Load(object sender, EventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new UserDataContext());
            facade.EnsureCreated();
        }

        private void CreatorInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game was made by 3 dead possums", "Thanks for playing this game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}