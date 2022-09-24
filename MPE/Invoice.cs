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
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string Article
        {
            get { return _article; }
            set { _article = value; }
        }

        private double _sum;
        public double Sum
        {
            get { return _sum; }
            set { _sum = value; }
        }
        public Invoice(int account,string customer,string provider)
        {
            this._account = account;
            this._customer = customer;
            this._provider = provider;
        }

        public double tax()
        {
            double tax = 0;
            double sum = 0;
            Sum = sum;
            Random random = new Random();
            int price = random.Next(10, 100);
            _quantity = _account / price;
            Article.ToLower();
            switch (Article)
            {
                case "with mpe":
                    {
                        tax = 0.20;
                        sum = (price * _quantity) * tax;
                        break;
                    }
                case "without mpe":
                    {
                        sum = price * _quantity;
                        break;
                    }
            }
            return sum;
        }


        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(10000, "Yehor", "Coca-cola");
            Console.WriteLine("If you wanna know sum with MPE is : with mpe");
            Console.WriteLine("If you wanna know sum without MPE is : without mpe");
            string article = Console.ReadLine();
            invoice.Article = article;
            Console.WriteLine(invoice.tax());
        }
    }
}
