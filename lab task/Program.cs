using System;

namespace ModuleTwoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int column = 0; column < 4; column++)  
            {
                for (int row = 0; row < 6; row++)
                {
                    if ((row + column) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if ((row + column) % 2 == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("Neither X nor O");  
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
