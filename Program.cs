using factory_method.Creators;
using factory_method.Products;
using System;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = null;
            Console.WriteLine("Que tipo de libro desea: ");
            Console.WriteLine("1.Magazine");
            Console.WriteLine("2.Comic");
            var type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    var magazine = new MagazineCreator();
                    book = magazine.GetBook();
                    break;
                case 2:
                    var comic = new ComicCreator();
                    book = comic.GetBook();
                    break;
                default:
                    break;
            }
            if (book != null)
                Console.WriteLine("su tipo de libro elegido es: " + book.Type);
            else
                Console.WriteLine("algo ha ocurrido...");

        }
    }
}
