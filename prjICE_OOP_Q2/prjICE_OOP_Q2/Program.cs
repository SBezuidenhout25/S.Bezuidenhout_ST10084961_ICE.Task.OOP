using System;

namespace prjICE_OOP_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squareArr = new Square[10];

            for (int x = 0; x < squareArr.Length; x++)
            {
                Console.WriteLine("Enter the side length of the square number" + (x+1));
                Console.Write("You: ");
                Square sqr = new Square(double.Parse(Console.ReadLine()));

                squareArr[x] = sqr; 
            }

            foreach(Square sq in squareArr)
            {
                Console.WriteLine(sq.ToString());
            }
            Console.ReadKey();
        }
    }
}
