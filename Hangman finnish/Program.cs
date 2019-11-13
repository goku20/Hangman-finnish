using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman_finnish
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            string[] wordBank = { " blomma", "stad", "gul", "växjö" };
            string GameWords = wordBank[random.Next(wordBank.Count() -1)];
            string GameWordsUpercase = GameWords.ToUpper();

            Console.WriteLine(GameWordsUpercase);
            StringBuilder dispToPlayer = new StringBuilder(GameWords.Length);

            for (int i = 0; i < wordBank.Length; i++)
                dispToPlayer.Append('_');
            //Console.WriteLine($" {wordBank});
           
            
        }
    }
}
