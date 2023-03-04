using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Airoportsdatabase
    {
        internal List<Airoportstable> Airoportstables { get; private set; }
        public void Initialize()
        {
            Airoportstables = new List<Airoportstable>()
            {

                new Airoportstable(new Adress("ул. Дружбы Народов д. 59"),new bulding("Международный аэропорт Абакан")),
                new Airoportstable(new Adress("2-я Рейсовая ул., 2, корп. 5, посёлок Внуково"),new bulding("Международный аэропорт Внуково"))





            };
        }
    }
}
