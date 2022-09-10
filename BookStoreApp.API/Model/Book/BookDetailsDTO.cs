﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Model.Book
{
    public class BookDetailsDTO : BaseDTO
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}