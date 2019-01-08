using System;

namespace lab01_aboutme
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1
            int answerForQ1 = q1Siblings();
            Console.WriteLine($"The answer is {answerForQ1}");

            //question 2
            string answerForQ2 = q2Color();
            Console.WriteLine($"The answer is {answerForQ2}");

            //question 3
            bool answerForQ3 = q3Foodie();
            Console.WriteLine($"The answer is {answerForQ3}");


            //question 4
            int answerForQ4 = q4FavNum();
            Console.WriteLine($"The answer is {answerForQ4}");

            //question 5
            string answerForQ5 = q5Name();
            Console.WriteLine($"The answer is {answerForQ5}");
            Console.ReadLine(); // so it doesn't auto exit

        }

        //question one, asks the user for guess, determine if it is right or wrong, returns correct answer
        private static int q1Siblings()
        {
            Console.WriteLine("How many siblings do I have?");
            string q1SiblingsGuess = Console.ReadLine();
            int q1SiblingsGuessInt = Convert.ToInt32(q1SiblingsGuess);
            int q1Answer = 1;
            if (q1SiblingsGuessInt != q1Answer)
            {
                Console.WriteLine("Good guess");
            }
            return q1Answer;
        }

        //question two, return string
        private static string q2Color()
        {
            Console.WriteLine("What is my favorite color?");
            string q2Answer = "Pink";
            return q2Answer;
        }

        //question three, return boolean
        private static bool q3Foodie()
        {
            Console.WriteLine("True or false: I am a foodie");
            bool q3Answer = true;
            return q3Answer;
        }

        //question four, return int
        private static int q4FavNum()
        {
            Console.WriteLine("What is my favorite Number?");
            int q4Answer = 36;
            return q4Answer;
        }

        //question five, return string
        private static string q5Name()
        {
            Console.WriteLine("What is my current favorite name?");
            string q5Answer = "Jasper";
            return q5Answer;
        }
    }
}
