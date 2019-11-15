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
        static List<char> GuessedChars = new List<char>();
        static List<string> WordBank = new List<string>();
        static void Main(string[] args)

        {




            Random random = new Random();
            string[] wordBank = { " blomma", "stad", "gul", "växjö" };

            string GameWords = wordBank[random.Next(wordBank.Count() - 1)];
            string GameWordsUpercase = GameWords.ToUpper();
            Console.WriteLine(GameWordsUpercase);

            PlayHangman();

        }

        static void PlayHangman()
        { 
                Random rand = new Random();
            string GameWords = wordBank[rand.Next(wordBank.Count() - 1)];
         


            //StringBuilder dispToPlayer = new StringBuilder(GameWords.Length);
            //for (int i = 0; i < GameWords.Length; i++)
            //dispToPlayer.Append('_');

            //GameWordsLength = GameWords.Length;


            //StringBuilder dispToPlayer = new StringBuilder(GameWords.Length);
            //for (int i = 0; i < GameWords.Length; i++)
            //    dispToPlayer.Append('_');
            ////Console.WriteLine(dispToPlayer);


            List<char> GuessedChars = new List<char>();
            List<char> incorrectGuesse = new List<char>();
           
            //string input;
            //char guess;
            //while ( !won && lives > 0 )


            //input = Console.ReadLine().ToUpper();
            //guess = input[0];



            lives = 10;
            //bool won = false;
            //int lettersReve = 0;
            Console.WriteLine(" Lives:  " + lives + "\n");
            //Console.WriteLine(" welcome  and guess a letter: ");
            //char guess = Char.ToLower(Console.ReadKey().KeyChar);
            string winning = "";
            int drawLength = 0;
            //GameWordsLength = GameWords.Length;

            for (int i = 0; i < GameWords.Length; i++)

            {

                if (GuessedChars.Any())
                {
                    if (GuessedChars.Contains(GameWords[i]))

                        Console.Write(GameWords[i].ToString() + " ");
                    winning += GameWords[i].ToString();
                    if (winning == GameWords)
                    {
                        //win();
                        return;
                        //dispToPlayer.Append('_');
                    }
                    else
                        Console.Write("_");
                    //dispToPlayer.Append('_');
                }
                else

                {
                    //dispToPlayer.Append('_');
                    Console.Write("_");
                }
            }

            Console.WriteLine("\n\n");
            Console.WriteLine(" welcome  and guess a letter: ");
            //Console.ReadKey().ToUpper;
            char guess = Char.ToUpper(Console.ReadKey().KeyChar);
            string input;




            Console.WriteLine();
            bool guessedOne = false;

            for (int i = 0; i < GameWords.Length; i++)

            {
                if (GameWords[i] == guess)
                {
                    guessedOne = true;
                    GuessedChars.Add(GameWords[i]);
                    //GuessedChars.Replace(GameWords[i]);

                }
                if (guessedOne == false)
                    --lives;

                if (lives <= 0) ;
                Restart();





            }

        }
        static void Restart()
        {
            Console.WriteLine(" du vann inte vill du spela igen? j/n; ");
            char answer = Console.ReadKey().KeyChar;

            if (char.ToLower(answer) == 'j')
            {
               // PlayHangman();
            }
        }
        static void won()
        {
            Console.WriteLine("\n\n Grattis! du vann! vill du splea igen j/n");
            char answer = Console.ReadKey().KeyChar;

            if (Char.ToLower(answer) == 'j')

            {
               // PlayHangman();
            }
        }
    }


}
