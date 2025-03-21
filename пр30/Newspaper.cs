using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр30
{
    public class Newspaper : PrintProduct
    {
        public int Circulation { get; set; }
        public int NumberOfPages { get; set; }
        public decimal PricePerPage { get; set; }

        public override decimal CalculatePrintRunCost()
        {
            return Circulation * NumberOfPages * PricePerPage;
        }

        public override void PrintDescription()
        {
            Console.WriteLine($"Газета: {Name}, Тираж: {Circulation}, Количество листов: {NumberOfPages}, Стоимость листа: {PricePerPage} руб.");
        }
    }
}
