using System;

namespace prjICE_OOP
{
    class Program
    {
        static void Main(string[] args)
        { 
            string strName;
            double dblAmount, dblCommisionRate;

            Console.WriteLine("Please enter your name:");
            strName = Console.ReadLine();
            Console.WriteLine("Enter a 1 to continue or 0 to finish");
            SalesTransaction s1;

            if (Console.ReadLine().Equals("1"))
            {
                Console.WriteLine("Please enter sales amount:");
                dblAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a 1 to continue or 0 to finish");

                if (Console.ReadLine().Equals("1"))
                {
                    Console.WriteLine("Please enter the commision rate (%):");
                    dblCommisionRate = Convert.ToDouble(Console.ReadLine());
                    s1 = new SalesTransaction(strName, dblAmount, dblCommisionRate);
                }
                else
                {
                    s1 = new SalesTransaction(strName, dblAmount);
                }
                
            }
            else
            {
                s1 = new SalesTransaction(strName);

            }

            Console.WriteLine(s1.strOutput());
            Console.ReadKey();

        }
    }
}
