namespace WindowsFormsApp8
{


    internal class flightabl
    {

        private Passenger _passenger;



        public Passenger passengers
        {
            get => _passenger.Name;
        }







        public flightabl(Passenger passenger)
        {

            _passenger = passenger;

        }
    }
}


