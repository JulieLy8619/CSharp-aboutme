using System;

namespace lab01_aboutme
{
    class Program
    {
        static void Main(string[] args)
        {

            //calls methods for each question
            q1Siblings();
            q2Color();
            q3Foodie();
            q4FavNum();
            q5Name();
        }

        //question one, return int
        private static int q1Siblings()
        {
            Console.WriteLine("How many siblings do I have?");
        }

        //question two, return string
        private static string q2Color()
        {
            Console.WriteLine("What is my favorite color?");
        }

        //question three, return boolean
        private static bool q3Foodie()
        {
            Console.WriteLine("True or false: I am a foodie");
        }

        //question four, return int
        private static int q4FavNum()
        {
            Console.WriteLine("What is my favorite Number?");
        }

        //question five, return string
        private static string q5Name()
        {
            Console.WriteLine("What is my current favorite name?");
        }
    }
}
