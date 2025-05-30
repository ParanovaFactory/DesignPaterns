﻿using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Composite.DAL
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int UpperCategoryId { get; set; }
        public List<Product> Products { get; set; }
    }
}
