using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp8

{


    internal class flightabl
    {

        private Passenger _passenger;
        private Airplane _airplane;
        private place _place;
        private Path _path;




        public string passengers
        {
            get { return _passenger.Name != null ? _passenger.Name : "Не назначено"; }
        }
        public int Place
        {
            get => _place.Place;
        }
        public string PlaneName
        {
            get { return _airplane.Name != null ? _airplane.Name : "Не назначено"; }
        }
        public string Path
        {
            get { return _passenger.Name != null ? _passenger.Name : "Не назначено"; }
        }






        public flightabl(Passenger passenger ,Airplane airplane, place Place, Path path)
        {

            _passenger = passenger;
            _airplane = airplane;
            _place = Place;
            _path = path;

        }
    }
}


