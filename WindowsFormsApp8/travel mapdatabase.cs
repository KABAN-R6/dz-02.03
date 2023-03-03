using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class travel_mapdatabase
    {
        internal List<travel_maptabl> travel_Maptabls { get; private set; }
        public void Initialize()
        {
            travel_Maptabls = new List<travel_maptabl>()
            {

                new travel_maptabl(new Point("Москва"),new Point("Екатеринбург"),new Point("Санкт-Петербург")),
                new travel_maptabl(new Point("Новосибирск"),new Point("Казань"),new Point("Москва"))





            };
        }
    }
}
