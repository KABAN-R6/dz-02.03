﻿using System;
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
               
                new flightabl(new Passenger("Валера"),new Airplane("F-35")),
                new flightabl(new Passenger("Дима"),new Airplane("B-2"))




            };
        }
    }
}
