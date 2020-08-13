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
            Guess();

            Console.WriteLine("Welcome to Hangman. Enter ur Guess");
            //ShowMainMenu();
            //OnUserInput();
        }

        public static void HangManGenerator(int limbs)
        {


            Scaffold();




            if (limbs == 1)
            {
                WriteAt("O", 5, 2);
                //Scaffold();
            }


            if (limbs == 2)
            {

                WriteAt("O", 5, 2);
                WriteAt("|", 5, 3);

                //Scaffold();
            }


            if (limbs == 3)
            {
                WriteAt("O", 5, 2);
                WriteAt("|", 5, 3);
                WriteAt("\\", 6, 3);
                
                //Scaffold();
            }


            if (limbs == 4)
            {
                WriteAt("/", 4, 3);
                WriteAt("O", 5, 2);
                WriteAt("|", 5, 3);
                
                WriteAt("/", 4, 3);
                //Scaffold();
            }


            if (limbs == 5)
            {
                WriteAt("/", 4, 3);
                WriteAt("O", 5, 2);
                WriteAt("|", 5, 3);
                WriteAt("\\", 6, 3);
                WriteAt("/", 4, 3);
                WriteAt("/", 4, 4);
                //Scaffold();
            }

            if (limbs == 6)
            {
                WriteAt("/", 4, 3);
                WriteAt("O", 5, 2);
                WriteAt("|", 5, 3);
                WriteAt("\\", 6, 3);
                WriteAt("/", 4, 3);
                WriteAt("/", 4, 4);
                WriteAt("\\", 6, 4);
                //Scaffold();
            }




        }
        //int index = random.next(list.count - 1);
        //TODO




        public static void Scaffold()
        {
            string[] drawHangMan = new string[8];

            drawHangMan[0] = "|";
            drawHangMan[1] = "+----+";
            drawHangMan[2] = "-";


            Console.WriteLine(drawHangMan[0], 5, 1);
            Console.WriteLine(drawHangMan[1], 0, 0);
            Console.WriteLine(drawHangMan[0], 0, 1);
            Console.WriteLine(drawHangMan[0], 0, 2);
            Console.WriteLine(drawHangMan[0], 0, 3);
            Console.WriteLine(drawHangMan[0], 0, 4);
            Console.WriteLine(drawHangMan[2], 0, 5);
            Console.WriteLine(drawHangMan[0], 0, 5);
            Console.WriteLine(drawHangMan[2], 1, 5);
            Console.WriteLine(drawHangMan[2], 2, 5);
            Console.WriteLine(drawHangMan[2], 3, 5);
            Console.WriteLine(drawHangMan[2], 4, 5);
            Console.WriteLine(drawHangMan[2], 5, 5);
            Console.WriteLine(drawHangMan[2], 6, 5);

            
        }




        //public static void GuessCharacter(int limbs)
        //{
        //    string word = "gerald";
        //    char[] letter = word.ToCharArray();


        //    string x = Console.ReadLine();
        //    char personInput = Convert.ToChar(x);


        //    for (int i = 0; i < 6; i++)
        //    {
        //        if (personInput != letter[0])
        //        {
        //            Console.WriteLine("Incorrect: {0}", personInput);
        //            limbs++;
        //        }
        //        if (personInput == letter[i])
        //        {

        //            Console.WriteLine(personInput);
        //            Console.WriteLine("Correct!");
        //        }
        //        for (int j = 0; j < 1; j++)
        //        {
        //            x = Console.ReadLine();
        //        }
        //    }


        public static void Guess()
        {
            int limbs = 0;
            HangManGenerator(limbs);
            var random = new Random();
            var list = new List<string> { "gerald", "aaron", "justin", "angela" };
            int index = random.Next(list.Count);

            //creates remain array
            char[] remain = list[index].ToCharArray();
            //creates result array
            char[] result = new char[remain.Length];

            while (true)
            {


                


                string x = Console.ReadLine();

                char personInput = Convert.ToChar(x);

                //prints g e r a l d reamins
                for (int i = 0; i < remain.Length; i++)
                {
                    Console.Write("" + remain[i]);
                }
                Console.Write("  ");


                //prints  the resukt
                //for (int i = 0; i < remain.Length; i++)
                //{
                //    Console.Write("  ");
                //    Console.Write("  " + result[i]);

                //}
                //Console.WriteLine(personInput);
                //Console.Write(" ");
                //Console.Write("");

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

                if (! guessedCorrect)
                {
                    limbs++;
                }

                for (int i = 0; i < remain.Length; i++)
                {
                    Console.Write("  ");
                    Console.Write("  " + result[i]);

                }
                Console.WriteLine(personInput);
                Console.Write(" ");
                Console.Write("");

                HangManGenerator(limbs);

                if (limbs == 7)
                {
                    LoseScreen();
                }
            }

        }

        public static void LoseScreen()
        {
            Console.Clear();
            Console.WriteLine("YOU LOSE. Type menu to go back to the main screen");
        }


    }
}




