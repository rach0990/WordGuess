using System.Runtime.Remoting.Services;
using System.Windows.Forms;


namespace Lingo
{
    class Score 
    {
         public int score = 0;

        public void EasyScore(string currentGuessBox)
        {
                     
            switch (currentGuessBox) 
            {

                case "guess1":
                case "medGuess1":
                case "hardGuess1":               
                     score+= 5;
                    break;

                case "guess2":
                case "medGuess2":
                case "hardGuess2":
                    score+=4;
                    break;

                case "guess3":
                case "medGuess3":
                case "hardGuess":
                    score+=3;
                    break;

                case "guess4":
                case "medGuess4":
                case "hardGuess4":
                    score+=2;
                    break;

                case "guess5":
                case "medGuess5":
                case "hardGuess5":
                    score+=1;
                    break;

                default:
                   
                    break;   
            }                       
        }

        public int Zero()
        {
           return score = 0;
        }
    }
}

