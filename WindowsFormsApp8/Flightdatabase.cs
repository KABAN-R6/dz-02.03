﻿using System;
using System.Collections.Generic;


namespace WindowsFormsApp8

{
    class Flightsdatabase
    {
        internal List<flightabl> flighttables { get; private set; }
        public void Initialize()
        {
            flighttables = new List<flightabl>
            {
                new flightabl(new Passenger("fasfa")),
                new flightabl(new Passenger("asfasf")),
                new flightabl(new Passenger("dfhshdga")),




            };
        }
    }
}
