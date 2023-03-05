using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Price
    {
        private int _price;

        public int price
        {
            get => _price;
            private set => _price = value;
        }

        public Price(int price)
        {
            _price = price;
        }
    }
}
