using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_practice
{
    internal class Program
    {
        public static int countTrue = 0, countFalse = 0, process = 0, action = 0, processAbout = 0, processLevel = 0, finishProcess = 0;
        public static bool levelEasy = false, levelMid = false, levelHard = false;


        public static void Main(string[] args)
        {
            Console.Clear();
            printMenu();
            if (process == 1)
            {
                selectLevel();
                for (int i = 1; i <= 10; i++)
                {
                    Add(GenerateNumber(), GenerateNumber2());
                }
                printNote();
                finishProcces();
                if(finishProcess==1) { Main(args); }
                else if (finishProcess == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (process == 2)
            {
                selectLevel();
                for (int i = 1; i <= 10; i++)
                {
                    Sub(GenerateNumber(), GenerateNumber2());
                }
                printNote();
                finishProcces();
                if (finishProcess == 1) { Main(args); }
                else if (finishProcess == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (process == 3)
            {
                selectLevel();
                for (int i = 1; i <= 10; i++)
                {

                    Div(GenerateNumber(), GenerateNumber2());

                }
                printNote();
                finishProcces();
                if (finishProcess == 1) { Main(args); }
                else if (finishProcess == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (process == 4)
            {
                selectLevel();
                for (int i = 1; i <= 10; i++)
                {
                    Multi(GenerateNumber(), GenerateNumber2());

                }
                printNote();
                finishProcces();
                if (finishProcess == 1) { Main(args); }
                else if (finishProcess == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (process == 5)
            {
                selectLevel();
                Console.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    GenerateAction();
                    if (action == 1)
                    {
                        Add(GenerateNumber(), GenerateNumber2());
                        Console.Clear();

                    }
                    else if (action == 2)
                    {
                        Sub(GenerateNumber(), GenerateNumber2());
                        Console.Clear();

                    }
                    else if (action == 3)
                    {
                        Div(GenerateNumber(), GenerateNumber2());
                        Console.Clear();

                    }
                    else if (action == 4)
                    {
                        Multi(GenerateNumber(), GenerateNumber2());
                        Console.Clear();

                    }
                }
                printNote();
                finishProcces();
                if (finishProcess == 1) { Main(args); }
                else if (finishProcess == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (process == 6)
            {
                Console.Clear();
                About();
                if (processAbout == 1)
                {
                    Main(args);
                }
                else if (processAbout == 2)
                {
                    Environment.Exit(0);
                }
            }
            else if (process == 7)
            {
                Environment.Exit(0);
            }
            else
            {
                Main(args);
            }
            Console.ReadLine();
        }

        public static int printMenu()
        {
            Console.WriteLine("Welcome to math practice");
            Console.WriteLine();
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Division");
            Console.WriteLine("[4] Multiplication");
            Console.WriteLine("[5] Random");
            Console.WriteLine("[6] About this application");
            Console.WriteLine("[7] Exit");
            Console.WriteLine();
            Console.WriteLine("Which action do you want to perform?");
            try
            {
                process = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("The operation could not be performed.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
            return process;
        }

        public static void selectLevel()
        {
            Console.Clear();
            Console.WriteLine("[1] Easy");
            Console.WriteLine("[2] Medium");
            Console.WriteLine("[3] Hard");
            Console.WriteLine();
            Console.WriteLine("Which level do you want to choose?");
            try
            {
                processLevel = Convert.ToInt32(Console.ReadLine());
                if (processLevel == 1)
                {
                    levelEasy = true;
                    levelMid = false;
                    levelHard = false;
                }
                else if (processLevel == 2)
                {
                    levelEasy = false;
                    levelMid = true;
                    levelHard = false;
                }
                else if (processLevel == 3)
                {
                    levelEasy = false;
                    levelMid = false;
                    levelHard = true;
                }
                else
                {
                    selectLevel();
                }
            }
            catch
            {
                Console.WriteLine("The operation could not be performed.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }

        public static int GenerateNumber()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int randomNumber = 0;
            if (levelEasy == true)
            {
                randomNumber = random.Next(1, 11);
            }
            else if (levelMid == true)
            {
                randomNumber = random.Next(1, 101);
            }
            else if (levelHard == true)
            {
                randomNumber = random.Next(1, 1001);
            }
            return randomNumber;
        }
        public static int GenerateNumber2()
        {
            Random random2 = new Random(Guid.NewGuid().GetHashCode());
            int randomNumber2 = 0;
            if (levelEasy == true)
            {
                randomNumber2 = random2.Next(1, 11);
            }
            else if (levelMid == true)
            {
                randomNumber2 = random2.Next(1, 101);
            }
            else if (levelHard == true)
            {
                randomNumber2 = random2.Next(1, 1001);
            }
            return randomNumber2;
        }

        public static int GenerateAction()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 5);
            return action = randomNumber;
        }

        public static void printNote()
        {
            Console.WriteLine("Number of correct responses: " + countTrue);
            Console.WriteLine("Number of incorrect responses: " + countFalse);
        }

        public static void Add(int number, int number2)
        {
            Console.Clear();
            Console.WriteLine("[1] Addition");
            Console.WriteLine();
            Console.Write(number + " + " + number2 + " = ");
            try
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                int result = number + number2;
                if (guess == result)
                {
                    countTrue++;
                }
                else
                {
                    countFalse++;
                }
            }
            catch
            {
                Console.WriteLine("The operation could not be performed.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }
        public static void Sub(int number, int number2)
        {
            Console.Clear();
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine();
            Console.Write(number + " - " + number2 + " = ");
            try
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                int result = number - number2;
                if (guess == result)
                {
                    countTrue++;
                }
                else
                {
                    countFalse++;
                }
            }
            catch
            {
                Console.WriteLine("The operation could not be performed.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }
        public static void Div(int number, int number2)
        {
            Console.Clear();
            Console.WriteLine("[3] Division");
            Console.WriteLine();
            int result = number / number2;
            if (number % number2 == 0)
            {
                Console.Write(number + " / " + number2 + " = ");
                try
                {
                    int guess = Convert.ToInt32(Console.ReadLine());
                    {
                        if (guess == result)
                        {
                            countTrue++;
                        }
                        else
                        {
                            countFalse++;
                        }
                    }

                }
                catch
                {
                    Console.WriteLine("The operation could not be performed.");
                    if (Console.KeyAvailable == true)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Div(GenerateNumber(), GenerateNumber2());
            }
        }
        public static void Multi(int number, int number2)
        {
            Console.Clear();
            Console.WriteLine("[4] Multiplication");
            Console.WriteLine();
            Console.Write(number + " x " + number2 + " = ");
            try
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                int result = number * number2;
                if (guess == result)
                {
                    countTrue++;
                }
                else
                {
                    countFalse++;
                }
            }
            catch
            {
                Console.WriteLine("The operation could not be performed.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }
        public static int About()
        {
            Console.Clear();
            Console.WriteLine("[6] About");
            Console.WriteLine();
            Console.WriteLine("Math Practice is an interactive C# console application designed to enhance your mathematical skills.");
            Console.WriteLine("It allows you to practice basic arithmetic operations while aiming to provide a fun and user-friendly experience.");
            Console.WriteLine();
            Console.WriteLine("Programmer by hakanberkeicellioglu");
            Console.WriteLine();
            Console.WriteLine("LinkedIn: https://www.linkedin.com/in/hakanberkeicellioglu/");
            Console.WriteLine("GitHub: https://github.com/hakanicellioglu");
            Console.WriteLine();
            Console.WriteLine("[1] Return to menu");
            Console.WriteLine("[2] Exit");
            try
            {
                processAbout = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("The operation could not be performed.");
                About();
            }
            return processAbout;
        }
        public static void finishProcces()
        {
            Console.WriteLine();
            Console.WriteLine("[1] Return to menu");
            Console.WriteLine("[2] Exit");
            try
            {
                finishProcess = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("The operation could not be performed.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}