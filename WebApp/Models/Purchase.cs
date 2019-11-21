using System;

namespace WebApp.Models
{
    public class Purchase
    {
        
        public int PurchaseId { get; set; }
        
        public string NickName { get; set; }

        public string Email { get; set; }
        
        public int BookId { get; set; }

        public DateTime Date { get; set; }
    }
}