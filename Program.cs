using System;
using System.Threading;
using System.Collections.Generic;






namespace HangMan
{

    class Program
    {
        protected static int origRow;
        protected static int origCol;
        protected static void WriteAt(string s, int col, int row)
        {
            try
            {
                Console.SetCursorPosition(origCol + col, origRow + row);
                Console.WriteLine(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public static void Main(string[] args)
        {
            origRow = 3;
            origCol = 3;
            Console.WriteLine("Welcome to Hangman. Enter ur Guess");
            Guess();
        }

        public static void HangManGenerator(int limbs)
        {
            if (limbs == 1)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine("\n");
            }

            if (limbs == 2)
            {

                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");

                //Scaffold();
            }

            if (limbs == 3)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");

                //Scaffold();
            }

            if (limbs == 4)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
                //Scaffold();
            }

            if (limbs == 5)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   /");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
                //Scaffold();
            }

            if (limbs == 6)
            {
                Console.WriteLine("|----+");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / \\");
                Console.WriteLine("|");
                Console.WriteLine("+-------+");
                Console.WriteLine(" \n");
                //Scaffold();
            }
        }
        public static void Guess()
        {
            int limbs = 0;

            var random = new Random();
            var nameList = new List<string> { "gerald", "aaron", "justin", "angela" };
            int randomName = random.Next(nameList.Count);

            //creates remain array
            char[] remain = nameList[randomName].ToCharArray();
            //creates result array
            char[] result = new char[remain.Length];

            Console.WriteLine("|----+");
            Console.WriteLine("|    |");
            Console.WriteLine("|    ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("+-------+");
            Console.WriteLine("\n");
            while (true)
            {
                object b = typeof(string);
                Console.WriteLine("Type Letter: ");
                
                string x = Console.ReadLine();

                while (x.Length != 1)
                {
                    Console.WriteLine("Invalid Input, try again.");
                    x = Console.ReadLine();
                }

                char personInput = Convert.ToChar(x);
                Console.WriteLine(" ");
                //the process of switching remian to result
                var guessedCorrect = false;

                for (int i = 0; i < remain.Length; i++)
                {
                    if (personInput == remain[i])
                    {
                        char temp = remain[i];
                        remain[i] = ' ';
                        result[i] = temp;
                        guessedCorrect = true;
                    }
                }

                if (!guessedCorrect)
                {
                    limbs++;
                    Console.WriteLine("That letter was incorrect.");
                }
                
                for (int i = 0; i < remain.Length; i++)
                {
                    Console.Write(result[i]);
                    
                }
                Console.WriteLine("   ");
                Console.Write("");
                Console.Write("");

                var win = true;
                for (int i = 0; i < remain.Length; i++)
                {
                    if (remain[i] != ' ')
                    {
                        win = false;
                    }
                }
                if (win)
                {
                    Console.WriteLine("Congrats! You Won!");
                    break;
                }

                HangManGenerator(limbs);

                if (limbs == 6)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("YOU LOSE.");
                    Console.WriteLine("The word was " + nameList[randomName]);
                    break;
                }
            }


        }





    }
}




