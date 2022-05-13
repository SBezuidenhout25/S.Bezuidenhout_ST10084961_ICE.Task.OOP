using System;

namespace prjICE_OOP_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, height;
            int sizeSelection;
            int typeSelection;

            Console.WriteLine("Choose a photo size, Enter a:\n1 for 8 by 10 inches\n2 for 10 by 12 inches" +
                "\n3 for custom size");
            Console.Write("You: ");
            sizeSelection = int.Parse(Console.ReadLine());

            Console.WriteLine("\nChoose a photo type, Enter a:\n1 for Matted photo\n2 for Framed photo\n3 for Normal photo");
            Console.Write("You: ");
            typeSelection = int.Parse(Console.ReadLine());

            Photo p;

            switch (typeSelection)
            {
                case 1:
                    Console.WriteLine("\nPlease enter a color");
                    Console.Write("You: ");
                    p = new MattedPhoto(Console.ReadLine());
                    break;


                case 2:
                    Console.WriteLine("\nPlease enter a frame type");
                    Console.Write("You: ");
                    p = new FramedPhoto(Console.ReadLine());
                    break;

                case 3:
                    p = new Photo();
                    break;
                default:
                    p = new Photo();
                    break;
            }

            switch (sizeSelection)
            {
                case 1:
                    p.width = 8;
                    p.height = 10;
                    break;

                case 2:
                    p.width = 10;
                    p.height = 12;
                    break;

                case 3:
                    Console.WriteLine("\nEnter width for photo");
                    Console.Write("You: ");
                    p.width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height for photo");
                    Console.Write("You: ");
                    p.height = double.Parse(Console.ReadLine());
                    break;

                default:
                    p.width = 0;
                    p.height = 0;
                    break;
            }
            p.getPrice(sizeSelection);
            Console.WriteLine(p.ToString());
            Console.ReadKey();

        }
    }
}
