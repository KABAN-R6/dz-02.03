using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class age
    {
        private int _age;

        public int Age
        {
            get => _age;
            private set => _age = value;
        }

        public age(int age)
        {
            _age = age;
        }
    }
}
