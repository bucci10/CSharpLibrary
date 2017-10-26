using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Objects_Challenges
{
    class Netflix

    {
        // Properties. Ignore the get; set; for now..
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }


        //  Calling the methods on the object (invoking, executing function/methods)

        public void GetSuggestion()
        {
            if (this.Rating > 4)
            {
                Console.WriteLine("This is a pretty good show.");
            }

            else
            {
                Console.WriteLine("Don't waste your time.");
            }



        }






    }






}
