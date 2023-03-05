using System;
using System.Collections.Generic;


namespace WindowsFormsApp8

{
    class Flightsdatabase
    {
        internal List<flightabl> flighttables { get; private set; }
        public void Initialize()
        {
            flighttables = new List<flightabl>()
            {

                new flightabl(new Passenger("Дима"),new Airplane("B-2"),new place (30),new Path("Москва-Абакан"),new Price(100000)),
                new flightabl(new Passenger("Коля"),new Airplane("F-35"),new place (21),new Path("Абакан-Москва"),new Price(80000))





            };
        }
    }
}
