using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Path
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Path(string name)
        {
            _name = name;
        }
    }
}
