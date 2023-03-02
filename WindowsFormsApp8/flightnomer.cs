using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class flightnomer
    {
        public int _price;

        public int Price
        {
            get => _price;
            private set => _price = value;
        }

        public flightnomer(int price)
        {
            _price = price;
        }
    }
}
