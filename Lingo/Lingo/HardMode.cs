using System;
using System.Collections.Generic;

namespace Lingo
{
    public class HardMode
    {
        List<string> hardMode;

        public HardMode()
        {
            hardMode = new List<string> { "accept", "bottle", "castle", "double", "empire", "finish" };
        
        }

        public string randomGenerator()
        {
            var random = new Random();
            int hardRand = random.Next(hardMode.Count);

            return hardMode[hardRand];

        }


    }
}

