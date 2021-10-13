using System;
using System.Collections.Generic;

namespace Lingo
{
    public class MediumMode : IGameMode 
    {
        List<string> mediumMode;

        public  MediumMode()
        {
            mediumMode = new List<string> { "about", "blank", "check", "drown", "entry", "pizza" };
        }

        public string RandomGenerator()
        {
            var random = new Random();
           int randMed = random.Next(mediumMode.Count);

            return mediumMode[randMed];



        }
    }
}

