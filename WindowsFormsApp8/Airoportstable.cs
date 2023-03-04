using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Airoportstable
    {
        private Adress _adress;
        private bulding _bulding;
        



        public string adress
        {
            get { return _adress.Name != null ? _adress.Name: "Не назначено"; }
        }
        public string buldings
        {
            get { return _bulding.Name!= null ? _bulding.Name : "Не назначено"; }
        }
        







        public Airoportstable(Adress adres, bulding bulding)
        {

            _adress = adres;
            _bulding = bulding;
            


        }
    }
}
