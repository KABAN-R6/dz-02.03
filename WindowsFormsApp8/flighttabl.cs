namespace WindowsFormsApp8
{


    internal class flightabl
    {

        private Passenger _passenger;



        public string passengers
        {
            get { return _passenger.Name != null ? _passenger.Name : "Не назначено"; }
        }







        public flightabl(Passenger passenger)
        {

            _passenger = passenger;

        }
    }
}


