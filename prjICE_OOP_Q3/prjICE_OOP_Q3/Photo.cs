using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE_OOP_Q3
{
    class Photo
    {
        public double width { get; set; }
        public double height { get; set; }

        public double newPrice;

        protected double[] price = new double [3]{ 3.99, 5.99, 9.99 };

        public virtual void getPrice(int priceNum)
        {
            newPrice = price[priceNum - 1];
        }

        public override string ToString()
        {
            string strOutput = "\nType: \t" + GetType().Name + "\nWidth: \t" + width + " inches" +"\nHeight: " + height + " inches" +
                 "\nPrice: \t" + "R " + Math.Round(newPrice, 2);
            return strOutput;
        }
    }
}
