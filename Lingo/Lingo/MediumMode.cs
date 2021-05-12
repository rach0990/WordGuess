using System;
using System.Collections.Generic;

namespace Lingo
{
    public class MediumMode
    {
        List<string> mediumMode;
        public  MediumMode()
        {
            mediumMode = new List<string> { "about", "blank", "check", "drown", "entry", "pizza" };
        }

        public string randomGenerator()
        {
            var random = new Random();
           int randMed = random.Next(mediumMode.Count);

            return mediumMode[randMed];



        }
    }
}

