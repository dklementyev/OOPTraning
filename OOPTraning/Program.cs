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
                var book = new Book
                {
                    Name = "NameOfBOok",
                    Author = "AuthorOfBook",
                    LendCost = 0.05m
                };
                context.Create(book);
                context.Save();
            }
            Console.Read();

            using (SQLBookRepository context = new SQLBookRepository())
            {
                var books = context.GetItems();

                foreach (var book in books)
                {
                    Console.WriteLine(book.ToString());
                }


            }
            Console.ReadLine();
        }
    }
}
