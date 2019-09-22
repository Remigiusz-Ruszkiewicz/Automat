using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    internal class Products
    {
        internal string Name { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
