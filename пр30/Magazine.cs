using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр30
{
    public class Magazine : PrintProduct
    {
        public int Circulation { get; set; }
        public decimal Price { get; set; }

        public override decimal CalculatePrintRunCost()
        {
            return Circulation * Price;
        }

        public override void PrintDescription()
        {
            Console.WriteLine($"Журнал: {Name}, Тираж: {Circulation}, Цена за экземпляр: {Price} руб.");
        }
    }
}
