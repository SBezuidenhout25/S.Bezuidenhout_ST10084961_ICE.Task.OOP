using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE_OOP_Q3
{
    class FramedPhoto : Photo
    {
        private double newPrice;
        private string type;

        public FramedPhoto(string type)
        {
            this.type = type;
        }

        public override void getPrice(int intPrice)
        {
            newPrice = price[intPrice - 1] + 25;
        }

        public override string ToString()
        {
            string strOutput = "\nType: \t" + GetType().Name + "\nWidth: \t" + width + " inches" + "\nHeight: " + height + " inches" +
                "\nFrame Type: \t" + type + "\nPrice: \t" + "R " + Math.Round(newPrice, 2);
            return strOutput;
        }
    }
}
