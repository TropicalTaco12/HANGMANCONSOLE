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
            origCol = 3;
            origRow = 3;
            int limbs = 3;
            HangManGenerator(5);

            //ShowMainMenu();
            //OnUserInput();
        }

        public static void HangManGenerator(int limbs)
        {
            

            Scaffold();


           

            if (limbs == 1)
            {

                WriteAt("O", 5, 2);
                Scaffold();
            }


            if (limbs == 2)
            {

                WriteAt("O", 5, 2);
                WriteAt("|", 5, 3);

                Scaffold();
            }


            if (limbs == 3)
            {
                WriteAt("O", 5, 2);
                WriteAt("|", 5, 3);
                WriteAt("\\", 6, 3);
                WriteAt("/", 4, 3);
                Scaffold();
            }


            if (limbs == 4)
            {
                WriteAt("/", 4, 3);
                WriteAt("O", 5, 2);
                WriteAt("|", 5, 3);
                WriteAt("\\", 6, 3);
                WriteAt("/", 4, 3);
                Scaffold();
            }


            if (limbs == 5)
            {
                WriteAt("/", 4, 3);
                WriteAt("O", 5, 2);
                WriteAt("|", 5, 3);
                WriteAt("\\", 6, 3);
                WriteAt("/", 4, 3);
                WriteAt("/", 4, 4);
                Scaffold();
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
                Scaffold();
            }


            //drawHangMan[0] = "O";
            //drawHangMan[1] = "|";
            //drawHangMan[2] = "/";
            //drawHangMan[3] = "\\";
            //drawHangMan[4] = "/";
            //drawHangMan[5] = "\\";
            //drawHangMan[6] = "-";
            //drawHangMan[7] = "+";

            //WriteAt(drawHangMan[1], 3, 2);
            //WriteAt(drawHangMan[7], 3, 1);
            //WriteAt(drawHangMan[6], 1, 1);
            //WriteAt(drawHangMan[6], 0, 1);
            //WriteAt(drawHangMan[1], )

            //WriteAt(drawHangMan[0], 3, 3);
            //WriteAt(drawHangMan[1], 3, 4);
            //WriteAt(drawHangMan[2], 2, 4);
            //WriteAt(drawHangMan[3], 4, 4);
            //WriteAt(drawHangMan[4], 2, 5);
            //WriteAt(drawHangMan[5], 4, 5);



            //WriteAt("O", 3, 3);
            //WriteAt("|", 3, 4);
            //WriteAt("/", 2, 4);
            //WriteAt("\\", 4, 4);
            //WriteAt("/", 2, 5);
            //WriteAt("\\", 4, 5);

        }

        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome To Hangman made by Only Justin");
            Console.WriteLine("Select a difficulty:");
            Console.WriteLine("1 for Easy");
            Console.WriteLine("2 for Meduim");
            Console.WriteLine("3 for HARD");
        }


        public static void OnUserInput()
        {

            string personInput = Console.ReadLine();
            


            if (personInput == "1")
            {
                int level = 1;
                Console.WriteLine("You have selected level: ", level);
            }
            else if (personInput == "2")
            {
                int level = 2;
                Console.WriteLine("You have selected level: ", level);
            }
            else if (personInput == "3")
            {
                int level = 3;
                Console.WriteLine("You have selected level: ", level);
            }

            if (personInput == "menu")
            {
                ShowMainMenu();
            }

        }
        
        public static void LevelOne()
        {
            var random = new Random();
            var list = new List<string> { "Gerald", "Angela", "Justin", "Aaron" };
            int index = random.Next(list.Count-1);
            Console.WriteLine(list[index]);

        }


        public static void LevelTwo()
        {
            var random = new Random();
            var list = new List<string> { "Paschal", "Nicholas", "Josephine", "Elizabeth" };
            int index = random.Next(list.Count-1);
            Console.WriteLine(list[index]);

        }



        public static void LevelThree()
        {
            var random = new Random();
            var list = new List<string> { "Annabella", "Isabella", "Andy Anderson the Second", "Christopher" };
            int index = random.Next(list.Count-1);
            Console.WriteLine(list[index]);

        }

        public static void Scaffold()
        {
            string[] drawHangMan = new string[8];

            drawHangMan[0] = "|";
            drawHangMan[1] = "+----+";
            drawHangMan[2] = "-";


            WriteAt(drawHangMan[0], 5, 1);
            WriteAt(drawHangMan[1], 0, 0);
            WriteAt(drawHangMan[0], 0, 1);
            WriteAt(drawHangMan[0], 0, 2);
            WriteAt(drawHangMan[0], 0, 3);
            WriteAt(drawHangMan[0], 0, 4);
            WriteAt(drawHangMan[2], 0, 5);
            WriteAt(drawHangMan[0], 0, 5);
            WriteAt(drawHangMan[2], 1, 5);
            WriteAt(drawHangMan[2], 2, 5);
            WriteAt(drawHangMan[2], 3, 5);
            WriteAt(drawHangMan[2], 4, 5);
            WriteAt(drawHangMan[2], 5, 5);
            WriteAt(drawHangMan[2], 6, 5);

           
        }

    }
}
