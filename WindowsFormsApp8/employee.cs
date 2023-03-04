using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class employee
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public employee(string name)
        {
            _name = name;
        }
    }
}
