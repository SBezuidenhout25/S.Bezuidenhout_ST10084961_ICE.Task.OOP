using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE_OOP_Q3
{
    class MattedPhoto : Photo
    {
        private double newPrice;
        private string color;
        public MattedPhoto (string color)
        {
            this.color = color;
        }

        public override void getPrice(int intPrice)
        {
            newPrice = price[intPrice - 1] + 10;
        }

        public override string ToString()
        {
            string strOutput = "\nType: \t" + GetType().Name +"\nWidth: \t"+ width + " inches" + "\nHeight: " + height + " inches" +
                "\nColor: \t" + color + "\nPrice: \t" + "R " + Math.Round(newPrice, 2); 
            return strOutput;
        }
    }
}
