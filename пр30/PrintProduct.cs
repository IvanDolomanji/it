using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр30
{
    public abstract class PrintProduct
    {
        public abstract decimal CalculatePrintRunCost();

        public abstract void PrintDescription();
        public string Name { get; set; }
    }
}
