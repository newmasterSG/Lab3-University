using System;
using System.Collections.Generic;

namespace MPE
{
    internal class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private readonly string _provider;

        private string _article;
        private int _quantity;
        
        public Invoice(int account,string customer,string provider)
        {
            this._account = account;
            this._customer = customer;
            this._provider = provider;
        }

        public double tax()
        {
            double tax = 0;
            double sumWithMPE;
            double sumWithoutMPE;
            switch(_article)
            {
                case "product":
                    {
                        tax = 0.20;

                        break;
                    }
            }
            return tax;
        }


        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(10000, "Yehor", "Coca-cola");
        }
    }
}
