using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE_OOP_Q2
{
    class Square
    {
        private double length;
        private double area;

        public Square (double length)
        {
            this.length = length;
            calculateArea();
        }

        private void calculateArea()
        {
            area = length * length;
        }

        public override string ToString()
        {
            string strOutput = "\n" + area + " square units";
            return strOutput;
        }
    }
}
