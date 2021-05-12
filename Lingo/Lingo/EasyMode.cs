using System;
using System.Collections.Generic;

namespace Lingo
{
    public class EasyMode
    {
        List<string> easyMode;
        public EasyMode()
        {


            easyMode = new List<string> { "back", "clap", "dust", "earn", "frog", "grab" };
            
        }




        public string randomGenerator() //create to use across all classes
        {

            ;
            var random = new Random();
            int ranIndex = random.Next(easyMode.Count);

           
            return easyMode[ranIndex];
        }


   
    }
}
