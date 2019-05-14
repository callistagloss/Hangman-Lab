using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class RandomPlayer : Player
    {  

    public override char Guess()        
        {

            char[] chars = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                                            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                            'y', 'z' };
            Random random = new Random();

            return chars[random.Next(chars.Length)]; //change this to random parameter stuff
         
                           
        }

    }
}
