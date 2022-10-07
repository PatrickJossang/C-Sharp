using System;
namespace Quizapp
{
    internal class Program
    {
        public static int correctAnswer;
        public static int questionNumber = 4;
        public static int score = 0;
        public static int totalQuestions = 1;

        public static void Quiz()
        {
            while (totalQuestions <= questionNumber)
            {
                switch (totalQuestions)
                {
                    case 1:

                        Console.WriteLine("What is the colour of the sky?");
                        Console.WriteLine("1. Blue");
                        Console.WriteLine("2. Red");
                        Console.WriteLine("3. Green");
                        Console.WriteLine("4. Yellow");
                        string? valg = (Console.ReadLine());

                        if (valg == "1")
                        {
                            Console.WriteLine("Correct");
                            score++;
                            totalQuestions++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect");
                            
                            totalQuestions++;
                        }

                        break;
                    case 2:
                        Console.WriteLine("What is the colour of the grass?");
                        Console.WriteLine("1. Blue");
                        Console.WriteLine("2. Red");
                        Console.WriteLine("3. Green");
                        Console.WriteLine("4. Yellow");
                        string? valg2 = (Console.ReadLine());
                        if (valg2 == "3")
                        {
                            Console.WriteLine("Correct");
                            score++;
                            totalQuestions++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect");
                            
                            totalQuestions++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("What is the colour of the sun?");
                        Console.WriteLine("1. Blue");
                        Console.WriteLine("2. cyan");
                        Console.WriteLine("3. Green");
                        Console.WriteLine("4. Yellow");
                        string? valg3 = (Console.ReadLine());
                        if (valg3 == "4")
                        {
                            Console.WriteLine("Correct");
                            score++;
                            totalQuestions++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect");
                            
                            totalQuestions++;
                        }
                        break;
                    case 4:
                        Console.WriteLine("What is the colour of the moon?");
                        Console.WriteLine("1. Blue");
                        Console.WriteLine("2. Red");
                        Console.WriteLine("3. gray");
                        Console.WriteLine("4. Yellow");
                        string? valg4 = (Console.ReadLine());
                        if (valg4 == "3")
                        {
                            Console.WriteLine("Correct");
                            score++;
                            totalQuestions++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect");
                            
                            totalQuestions++;
                        }
                        break;
                }
                
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz");

            Quiz();
            Console.WriteLine("You got " + score + " out of " + (totalQuestions -1));
            Console.WriteLine("you got " + (score * 100 / (totalQuestions -1)) + "%");
        }
    }
}