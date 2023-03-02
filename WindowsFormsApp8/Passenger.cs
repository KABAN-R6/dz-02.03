using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Passenger
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Passenger(string name)
        {
            _name = name;
        }
    }
}
