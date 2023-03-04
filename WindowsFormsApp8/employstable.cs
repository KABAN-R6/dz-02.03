using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class employstable
    {
        private employee _employess;
        private age _age;



        public string empluyeeName
        {
            get { return _employess.Name != null ? _employess.Name : "Не назначено"; }
        }
        
        public int age
        {
            get => _age.Age;
        }







        public employstable(employee employees , age Age)
        {

            _employess = employees;
            _age = Age;
            


        }
    }
}
