using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 2; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    string[,] array = new string[,]
                    {
                        {"cat", "dog", "fish"},
                        {"bird", "horse", "cow"},
                    };
                    Console.Write($"{array[row, column]}\t");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
