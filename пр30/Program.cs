using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите навзвание журнала");
            string magazineName = Console.ReadLine();

            Console.WriteLine("Введите тираж журнала");
            int magazineCirculation = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите цену за экземпляр журнала");
            decimal magazinePrice = decimal.Parse(Console.ReadLine());

            Magazine magazine = new Magazine
            {
                Name = magazineName,
                Circulation = magazineCirculation,
                Price = magazinePrice,
            };

            Console.WriteLine("Введите название газеты:");
            string newspaperName = Console.ReadLine();

            Console.WriteLine("Введите тираж газеты:");
            int newspaperCirculation = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество листов в газете:");
            int newspaperNumberOfPages = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость одного листа газеты:");
            decimal newspaperPricePage = decimal.Parse(Console.ReadLine());

            Newspaper newspaper = new Newspaper
            {
                Name = newspaperName,
                Circulation = newspaperCirculation,
                NumberOfPages = newspaperNumberOfPages,
                PricePerPage = newspaperPricePage
            };

            Console.WriteLine($"\nСтоимость тиража журнала {magazine.Name} = {magazine.CalculatePrintRunCost()} руб.");
            magazine.PrintDescription();

            
            Console.WriteLine($"\nСтоимость тиража газеты {newspaper.Name} = {newspaper.CalculatePrintRunCost()} руб.");
            newspaper.PrintDescription();

            Console.Read();






        }
    }
}
