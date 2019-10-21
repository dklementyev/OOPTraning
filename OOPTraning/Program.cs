using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPTraning.Entities;
namespace OOPTraning
{
    class Program
    {
        static void Main(string[] args)
        {
            //var admin = new Admin("Vladimir", "Mineev", "AdminUser1", "paassssword", 150000.00M);
            //var reader = new Reader("Alesha", "Popov", "aleshaPopov1996", "password12321");


            //admin.ShowInfo();
            //reader.ShowInfo();
            using (SQLBookRepository context = new SQLBookRepository())
            {
                var book = new Book();
                book.Name = "NameOfBOok";
                book.Author = "AuthorOfBook";
                book.LendCost = 0.05m;
                context.Create(book);
                context.Delete(3);
                context.Save();
            }
            Console.Read();
        }
    }
}
