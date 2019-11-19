using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OOPTraning.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal LendCost { get; set; }



        public override string ToString()
        {
            return $"#{this.BookId} {this.Name} {this.Author} {this.LendCost}";
        }
    }
}
