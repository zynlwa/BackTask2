﻿namespace FirstApp.Eterna.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImageUrl { get; set; }
    }
}
