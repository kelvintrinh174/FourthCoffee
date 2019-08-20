using System;
using System.Collections.Generic;
using System.Linq;
using FourthCoffee.Data;
using FourthCoffee.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FourthCoffee.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FourthCoffeeContext db;  
        public IndexModel(FourthCoffeeContext db) => this.db = db;
        public List<Product> Products { get; set; } = new List<Product>();  
        public Product FeaturedProduct { get; set; }  
        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
        }
    }
}
