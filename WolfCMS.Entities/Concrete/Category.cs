﻿namespace WolfCMS.Entities.Concrete
{
    public class Category : BaseClass
    {
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}