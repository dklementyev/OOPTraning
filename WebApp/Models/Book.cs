﻿namespace WebApp.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Name { get; set; }
        
        public string Author { get; set; }

        public int LendCost { get; set; }
    }
}