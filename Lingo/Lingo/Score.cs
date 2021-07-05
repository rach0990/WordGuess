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
                     score+= 5;
                    break;

                case "guess2":
                    score+=4;
                    break;

                case "guess3":
                    score+=3;
                    break;

                case "guess4":
                    score+=2;
                    break;

                case "guess5":
                    score+=1;
                    break;

                default:
                   
                    break;   
            }
            
        }

      
    }
}

