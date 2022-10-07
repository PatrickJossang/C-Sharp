using System;
namespace Quizapp
{
    internal class Program
    {
        public int correctAnswer;
        public int questionNumber = 1;
        public int score = 0;
        public int totalQuestions = 4;
        public float persentage = score / totalQuestions * 100;

        public void Quiz()
        {
            switch (questionNumber)
            {
                case 1:
                    correctAnswer = 1;
                    Console.WriteLine("What is the colour of the sky?");
                    Console.WriteLine("1. Blue");
                    Console.WriteLine("2. Red");
                    Console.WriteLine("3. Green");
                    Console.WriteLine("4. Yellow");
                    if (correctAnswer.Equals(Console.ReadLine()))
                    {
                        Console.WriteLine("Correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }

                    break;
                case 2:
                    Console.WriteLine("What is the colour of the grass?");
                    Console.WriteLine("1. Blue");
                    Console.WriteLine("2. Red");
                    Console.WriteLine("3. Green");
                    Console.WriteLine("4. Yellow");
                    correctAnswer = 3;
                    if (correctAnswer.Equals(Console.ReadLine()))
                    {
                        Console.WriteLine("Correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                    break;
                case 3:
                    Console.WriteLine("What is the colour of the sun?");
                    Console.WriteLine("1. Blue");
                    Console.WriteLine("2. cyan");
                    Console.WriteLine("3. Green");
                    Console.WriteLine("4. Yellow");
                    correctAnswer = 4;
                    if (correctAnswer.Equals(Console.ReadLine()))
                    {
                        Console.WriteLine("Correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                    break;
                case 4:
                    Console.WriteLine("What is the colour of the moon?");
                    Console.WriteLine("1. Blue");
                    Console.WriteLine("2. Red");
                    Console.WriteLine("3. gray");
                    Console.WriteLine("4. Yellow");
                    correctAnswer = 3;
                    if (correctAnswer.Equals(Console.ReadLine()))
                    {
                        Console.WriteLine("Correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                    break;

            }
            
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz");
            
            if (questionNumber == totalQuestions)
            {
                Console.WriteLine("You got " + score + " out of " + totalQuestions);
                Console.WriteLine("That is  the persentage" + persentage + "%");
            }
            else if (questionNumber < totalQuestions)
            {
                questionNumber++;
            }
        }
    }
}