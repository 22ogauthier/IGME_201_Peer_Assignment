/**
 * Olivia Croteau and Olivia Gauthier
 * IGME.201 Interac Des & Alg Prob Sol III
 * October 15,2024
 */

namespace Peer_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int livFavoriteNumber;
            int olliFavoriteNumber;

            //initialize
            livFavoriteNumber = 42;
            olliFavoriteNumber = 667;

            // returns the difference of two numbers passed in as parameters
            static int Subtract(int x, int y)
            {
                return x - y;
            }

            //start of our actual program
            Console.WriteLine("Liv's favorite number is: " + livFavoriteNumber);
            //olli needs to print this out
            Console.WriteLine("Olli's favorite number is: " + olliFavoriteNumber);

            int sum = Add(livFavoriteNumber, olliFavoriteNumber);
            Console.WriteLine("When we add our favorite numbers together we get: " + sum);

            int difference = Subtract(livFavoriteNumber, olliFavoriteNumber);
            Console.WriteLine("When we subtract our favorite numbers from each other we get: " + difference);
        }

        /// <summary>
        /// returns the sum of two numbers passed in as parameters
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>int</returns>
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
