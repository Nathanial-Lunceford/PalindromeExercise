using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class WordSmith
    {
        public bool IsAPalindrome(string s)
        {
            s = s.ToLower();

            char[] reversedArray = s.ToCharArray();
            Array.Reverse(reversedArray);

            var reversed = new string(reversedArray);

            if(s == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
