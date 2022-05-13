using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE_OOP
{
    class SalesTransaction
    {
        private string name;
        private double amount, commision, commisionRate;

        public SalesTransaction (string name, double amount, double commisionRate)
        {
            this.name = name;
            this.amount = amount;
            this.commisionRate = commisionRate;
            commision = amount * (commision / 100);
        }
        public SalesTransaction(string name, double amount)
        {
            this.name = name;
            this.amount = amount;
            commisionRate = 0;
            commision = 0;
        }
        public SalesTransaction(string name)
        {
            this.name = name;
            amount = 0;
            commisionRate = 0;
            commision = 0;
        }

        public string strOutput()
        {
            string strDisplay;
            strDisplay = "Name:\t" + name + "\nSale Amount:\tR" + amount + "\nCommision Rate:\tR" + commisionRate +
                "\nCommision:\tR" + commision;

            return strDisplay;
        }
    }
}
