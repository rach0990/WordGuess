using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lingo
{
    public partial class homepage : Form
    {

        
        string secretWord;
        string firstLetter;
        string medSecWrd;
        string medFirstLetter;
        string hardSecWrd;
        string hardFirstLetter;

        List<string> playGuess;

        Score Testing = new Score();



        public homepage()
        {
            InitializeComponent();

     



            playGuess = new List<string> { };
        }

        public void startNewGame()
        {
            EasyMode restart = new EasyMode();
            secretWord = restart.randomGenerator();
            firstLetter = secretWord.Substring(0, 1);

            //trying to call score
         

            guess1.Text = firstLetter;

            guess2.Clear();
            guess3.Clear();
            guess4.Clear();
            guess5.Clear();


            MediumMode MedRestart = new MediumMode();
            medSecWrd = MedRestart.randomGenerator();
            medFirstLetter = medSecWrd.Substring(0, 1);

            medGuess1.Text = medFirstLetter;

            medGuess2.Clear();
            medGuess3.Clear();
            medGuess4.Clear();
            medGuess5.Clear();

            HardMode hardRestart = new HardMode();
            hardSecWrd = hardRestart.randomGenerator();
            hardFirstLetter = hardSecWrd.Substring(0, 1);

            hardGuess1.Text = hardFirstLetter;

            hardGuess2.Clear();
            hardGuess3.Clear();
            hardGuess4.Clear();
            hardGuess5.Clear();




        }
        

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void EasyBtn_Click(object sender, EventArgs e)
        {
            easyPanel.Visible = true;

            startNewGame();

          
        }

        private void easyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Enter(object sender, KeyEventArgs e)
        {
            string correctLetters = "";


           if (e.KeyCode == Keys.Enter)
            {

                TextBox currentGuessBox = ((TextBox)sender);
                string currentGuessText = currentGuessBox.Text;
                playGuess.Add(currentGuessText);

               
               

              

                if (currentGuessText == secretWord)
                {

                    MessageBox.Show($"Well done you have guessed the secret word");
                  

                    easyPanel.Visible = false;

                    
                    Testing.EasyScore(currentGuessBox.Name);

                    ScoreLabel.Text = "Score: " + Testing.score;
                   
                   

                }

                else
                {

                    this.SelectNextControl((Control)sender, true, true, true, true);


                    foreach (char letter in currentGuessText)
                    {
                        if (secretWord.Contains(letter))
                        {

                            correctLetters += letter;


                        }
                        else
                        {
                            correctLetters += "?";
                            

                        }

                        

                        
                    }

                   

                    currentGuessBox.Text = correctLetters;
                    
                    

                  
                    

                  

                }
            }
        }

        private void EnterFinal(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string lastguess = guess5.Text;

                if (lastguess != secretWord)
                {

                    MessageBox.Show($" The secret word was {secretWord}");
                    easyPanel.Visible = false;

                }
                else
                {

                    MessageBox.Show("Well done you guessed the secret word!");

                    easyPanel.Visible = false;
                    //Possibly change to have button for new/next game?
                  
                }

            }
        }

        private void MediumBtn_Click(object sender, EventArgs e)
        {
            medPanel.Visible = true;
            startNewGame();
        }

        private void EnterMed(object sender, KeyEventArgs e)
        {
            string correctLetters = "";

            if (e.KeyCode == Keys.Enter)
            {             

                TextBox currentGuessBox = ((TextBox)sender);
                string currentGuessText = currentGuessBox.Text;
                playGuess.Add(currentGuessText);

                if (currentGuessText == medSecWrd)
                {

                    MessageBox.Show("Well done you have guessed the secret word");
                    medPanel.Visible = false;
                }

                else
                {

                    this.SelectNextControl((Control)sender, true, true, true, true);


                    foreach (char letter in currentGuessText)
                    {
                        if (medSecWrd.Contains(letter))
                        {

                            correctLetters += letter;


                        }
                        else
                        {
                            correctLetters += "?";

                        }


                    }

                    currentGuessBox.Text = correctLetters;
                }
            }

        }

        private void medEnterFinal(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string lastguess = medGuess5.Text;

                if (lastguess != medSecWrd)
                {
                    MessageBox.Show($" The secret word was {medSecWrd}");
                    medPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Well done you have guessed the secret word");
                    medPanel.Visible = false;
                }
            }
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {

            hardPanel.Visible = true;
            startNewGame();
        }

        private void EnterHard(object sender, KeyEventArgs e)
        {
            string CorrectLetters = "";



            if (e.KeyCode == Keys.Enter)
            {

                TextBox currentGuessBox = ((TextBox)sender);
                string currentGuessText = currentGuessBox.Text;
                playGuess.Add(currentGuessText);

                if (currentGuessText == hardSecWrd)
                {
                    MessageBox.Show("Well done you have guessed the secret word");
                    hardPanel.Visible = false;
                }

                else
                    this.SelectNextControl((Control)sender, true, true, true, true);

                foreach (char Letter in currentGuessText)
                {
                    if (hardSecWrd.Contains(Letter))
                    {
                        CorrectLetters += Letter;

                    }

                    else
                        CorrectLetters += "?";
                }

                currentGuessBox.Text = CorrectLetters;
                
            }

           


        }

        private void hardEnterFinal(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (hardGuess5.Text != hardSecWrd)
                {
                    MessageBox.Show($"The secret word was: {hardSecWrd}");
                    hardPanel.Visible = false;
                }
                else
                    MessageBox.Show("Well done you have guessed the secret word");
                hardPanel.Visible = false;
               
            }
        }

        private void howToPlayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To start the game click on what difficulty you want to play. The first box will give you what letter the word begins with. start typing your guess into the" +
                            "first box then press Enter. if you have guessed any letters correctly they will appear. watch out though they will not show you the order of the letters" +
                             "Good luck");
        }

        private void createUsernameBtn_Click(object sender, EventArgs e)
        {

        }

        private void hardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Scorecounter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

