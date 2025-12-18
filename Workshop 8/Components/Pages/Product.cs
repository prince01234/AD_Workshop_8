using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_8.Components.Pages
{
    internal class Product
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Likes { get; set; }
        public string ImageUrl { get; set; } = "";
    }
}
