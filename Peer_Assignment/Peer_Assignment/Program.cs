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

            static int Subtract(int x, int y)
            {
                return x - y;
            }

            //start of our actual program
            Console.WriteLine("Liv's favorite number is: " + livFavoriteNumber);
            //olli needs to print this out

            int sum = Add(livFavoriteNumber, olliFavoriteNumber);
            Console.WriteLine("When we add our favorite numbers together we get: " + sum);

            int difference = Subtract(livFavoriteNumber, olliFavoriteNumber);
            Console.WriteLine("When we subtract our favorite numbers from each other we get: " + difference);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
