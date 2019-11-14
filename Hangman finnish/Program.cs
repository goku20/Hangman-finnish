using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman_finnish
{
    class Program
    {
        static Random random;
        static int lives;
        //static int wordBank.Length;
        //static List<string> wordBank = new List<string>();
        //static string input;
        static string guess;
        static string GameWordsLength;
        static string CurrentWordLength;
        static string CurrentWord;
        static string GameWords;
        List<char> guessedChars = new List<char>();
        static void Main(string[] args)
        {

            Random random = new Random();
            string[] wordBank = { " blomma", "stad", "gul", "växjö" };
            string GameWords = wordBank[random.Next(wordBank.Count() - 1)];
            string GameWordsUpercase = GameWords.ToUpper();


            //Console.WriteLine(GameWordsUpercase);
            StringBuilder dispToPlayer = new StringBuilder(GameWords.Length);

            //for (int i = 0; i < wordBank.Length; i++)
            //dispToPlayer.Append('_');
            //Console.WriteLine($" {wordBank});


            playHangman();
        }
        static void playHangman()
        {
            lives = 10;
            bool won = false;
            //int lettersReve = 0;

            List<char> guessedChars = new List<char>();
            List<char> incorrectGuesse = new List<char>();
            //GameWordsLength = GameWords.Length;
            //string input;
            //char guess;
             //while ( !won && lives > 0 )

          
            //input = Console.ReadLine().ToUpper();
               //guess = input[0];
       
        

            Console.WriteLine(" Lives:  " + lives + "\n");
            Console.WriteLine(" welcome  and guess a letter: ");
            //char guess = Char.ToLower(Console.ReadKey().KeyChar);
            string winning = "";
            int drawLength = 0;

            for (int i = 0; i < GameWords.Length; i++)

            {

                if (GameWords.Any())
                {
                    if (GameWords.Contains(CurrentWord[i]))

                        Console.Write(CurrentWord[i].ToString() + " ");
                    winning += CurrentWord[i].ToString();
                    if (winning == CurrentWord)
                    {
                        //win();

                       
                    }
                    else
                        Console.Write("_");

                }
                else

                {
                    Console.Write("_");
                }
            }

            Console.WriteLine("\n\n");
            Console.WriteLine(" welcome  and guess a letter: ");
            //Console.ReadKey().KeyChar);
            char guess = Char.ToLower(Console.ReadKey().KeyChar);

            CheckGuess(guess);

        }
        static void CheckGuess(char guess)
        {

            Console.WriteLine();
            bool guessOne = false;

            for (int i = 0; i < GameWords.Length; i++)

            {
                if (CurrentWord[i] == guess)
                {

                    guessOne = true;
                    return;
                    //GameWords.Replace(CurrentWord[i]);

                }
                if (guessOne == false)
                    --lives;

                if (lives <= 0) ;

                   


            }

        }
        //Console.WriteLine(" Guess a letter: ");

        //string GameWords = wordBank[random.Next(wordBank.Count() - 1)];
        //string GameWordsUpercase = GameWords.ToUpper();
        //Console.WriteLine(GameWordsUpercase);
        //StringBuilder dispToPlayer = new StringBuilder(GameWords.Length);
        //for (int i = 0; i < wordBank.Length; i++)
    }

}
