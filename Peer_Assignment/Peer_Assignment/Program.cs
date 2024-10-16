namespace Peer_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int livFavoriteNumber;
            int olliFavoriteNumber;

            static int Subtract(int x, int y)
            {
                return x - y;
            }

            //initialize
            livFavoriteNumber = 42;
            olliFavoriteNumber = 667;

            //start of our actual program
            Console.WriteLine(livFavoriteNumber);
        }

        static void Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
