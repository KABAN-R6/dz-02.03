using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Stockdatabase
    {
        internal List<Stocktable> stocktables { get; private set; }
        public void Initialize()
        {
             stocktables = new List<Stocktable>()
            {

                new Stocktable(new Point("Москва-Питер"),new Price(20000)),
                new Stocktable(new Point("Питер-Иркутск"),new Price(38000))





            };
        }
    }
}
