using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class travel_maptabl
    {
        private Point _point;
        private Point _point1;
        private Point _point2;



        public string Point
        {
            get { return _point.Name != null ? _point.Name : "Не назначено"; }
        }
        public string Point1
        {
            get { return _point.Name != null ? _point.Name : "Не назначено"; }
        }
        public string Point2
        {
            get { return _point.Name != null ? _point.Name : "Не назначено"; }
        }







        public travel_maptabl(Point point , Point point1, Point point2)
        {

            _point = point;
            _point1 = point1;
            _point2 = point2;
            

        }
    }
}
