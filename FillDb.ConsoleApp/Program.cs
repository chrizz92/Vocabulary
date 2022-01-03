using Persistence;
using System;
using System.Threading.Tasks;

namespace FillDb.ConsoleApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                await uow.FillDbAsync();
                Console.WriteLine($"Es sind {uow.WordRepository.GetAll().Count} Paare eingelesen worden.");
            }
            Console.WriteLine();
            Console.Write("Bitte beliebige Taste zum Beenden drücken . . .");
            Console.ReadKey();
    
        }
    }
}
