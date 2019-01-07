using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDatabase_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Model1 db = new Model1())
            {
               foreach (Japanese i in db.Japanese)
                    Console.WriteLine($"{i.ID}. {i.Brand}, {i.Model}, {i.Year}, {i.Price}");
            }
            Console.ReadLine();
        }
    }
}
