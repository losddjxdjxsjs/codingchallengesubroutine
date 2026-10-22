

namespace ValidStringChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (!validString(input))
            {
                Console.Write("Please enter a valid string: ");
                input = Console.ReadLine();
            }


        }
        static bool validString(string input)
        {
            if (!correctLength(input))
            {
                return false;
            }
            return true;
        }
        static bool correctLength(string input)
        {
            if (input.Length < 5 || input.Length > 7)
            {
                return false;
            }
            return true;

        }
    }

}
