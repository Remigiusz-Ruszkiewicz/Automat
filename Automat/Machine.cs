using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    internal class Machine
    {
        internal Stack<Water> water { get; set; }
        internal Stack<Cola> cola { get; set; }
        internal Stack<Orange_Juice> juice { get; set; }
        internal Machine()
        {
            water = new Stack<Water>();
            for (int i = 0; i < 10; i++)
            {
                water.Push(new Water());
            }
            cola = new Stack<Cola>();
            for (int i = 0; i < 13; i++)
            {
                cola.Push(new Cola());
            }
            juice = new Stack<Orange_Juice>();
            for (int i = 0; i < 7; i++)
            {
                juice.Push(new Orange_Juice());
            }
        }
    }
}
