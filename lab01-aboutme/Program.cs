using System;

namespace lab01_aboutme
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1 prep/response
            Console.WriteLine("How many siblings do I have?");
            string q1SiblingsGuess = Console.ReadLine();
            int q1SiblingsGuessInt = Convert.ToInt32(q1SiblingsGuess);
            int answerForQ1 = q1Siblings(q1SiblingsGuessInt);
            Console.WriteLine($"");

            //question 2 prep/response
            string q2ColorGuess = q2Color(q2ColorGuess);

            //question 3 prep/response
            bool q3FoodieGuess = q3Foodie(q3FoodieGuess);

            //question 4 prep/response
            int q4FavNumGuess = q4FavNum(q4FavNumGuess);

            //question 5 prep/response
            string q5NameGuess = q5Name(q5NameGuess);
        }

        //question one, takes in users guess, determins if it is right or wrong and returns correct answer in int
        private static int q1Siblings(int q1Guess)
        {
            Console.WriteLine("How many siblings do I have?");
            return q1Answer;
        }

        //question two, return string
        private static string q2Color(string q2Guess)
        {
            Console.WriteLine("What is my favorite color?");
            return q2Answer;
        }

        //question three, return boolean
        private static bool q3Foodie(bool q3Guess)
        {
            Console.WriteLine("True or false: I am a foodie");
            return q3Answer;
        }

        //question four, return int
        private static int q4FavNum(int q4Guess)
        {
            Console.WriteLine("What is my favorite Number?");
            return q4Answer;
        }

        //question five, return string
        private static string q5Name(string q5Guess)
        {
            Console.WriteLine("What is my current favorite name?");
            return q5Answer;
        }
    }
}
