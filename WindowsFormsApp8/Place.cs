using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class place
    {
        private int _place;

        public int Place
        {
            get => _place;
            private set => _place = value;
        }

        public place(int place)
        {
            _place = place;
        }
    }
}
