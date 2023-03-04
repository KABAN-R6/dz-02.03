using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class employsdatabase
    {
        internal List<employstable> employs { get; private set; }
        public void Initialize()
        {
            employs = new List<employstable>()
            {
                new employstable(new employee("Коля"),new age (21)),
                new employstable( new employee("дима"),new age(25))
                


            };
        }
    }
}
