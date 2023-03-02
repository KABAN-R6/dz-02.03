namespace WindowsFormsApp8
{


    internal class flightabl
    {

        private Passenger _passenger;
        private Airplane _airplane;



        public string passengers
        {
            get { return _passenger.Name != null ? _passenger.Name : "Не назначено"; }
        }

        public string Name
        {
            get { return _airplane.Name != null ? _airplane.Name : "Не назначено"; }
        }





        public flightabl(Passenger passenger ,Airplane airplane)
        {

            _passenger = passenger;
            _airplane = airplane;

        }
    }
}


