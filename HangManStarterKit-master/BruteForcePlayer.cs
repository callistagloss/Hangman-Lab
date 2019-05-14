using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class BruteForcePlayer : Player
    {
        //start int or array at zero, then add 1 each time you call Guess
        int i = -1;



        public override char Guess()
        {                
                char[] chars = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                                            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                            'y', 'z' };

            i = i + 1;

            return chars[i];

            
            //The BruteForcePlayer will guess every Letter in sequence starting at a and ending at z. 
            //    This player will keep guessing until it wins. 
        }
        //keep track of prior guesses, then pass along current guess
        //increment i, then return chars[i];


    }
}
