using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Stocktable
    {
        private Price _price;
        private Point _point;





        public string Point
        {
            get { return _point.Name != null ? _point.Name : "Не назначено"; }
        }
        public int Price
        {
            get => _price.price;
        }
        






        public Stocktable(Point point, Price price)
        {
            _price = price;
            _point = point;
            
            

        }
    }
}
