using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering; 
using MakeupProject.Models;

namespace MakeupProject.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly MakeupProjectDbContext _context;

        public IndexModel(MakeupProjectDbContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }
        public SelectList SortList {get; set;}
        public int PageSize {get; set;} = 10;
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1; 
        public int TotalCount {get; set;}
        public int TotalPages {get; set;}
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        public string PriceSort {get; set;} 
        [BindProperty(SupportsGet = true)]    
        public string SearchString {get; set;} 


        public async Task OnGetAsync(string sortOrder)
        {
            CurrentSort = sortOrder;
            PriceSort = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";

            List<SelectListItem> sortItems = new List<SelectListItem>
            {
                new SelectListItem {Text = "High to Low", Value = "price_desc"},
                new SelectListItem ("Low to High", "price_asc")
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            var products = await _context.Product.ToListAsync();

            if (!string.IsNullOrEmpty(SearchString))
            {
                 products = products.Where(s => s.Brand.Contains(SearchString)).ToList();
            }

            TotalCount = products.Count(); 
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            switch(sortOrder)
            {
                 case "price_desc":
                 products = products.OrderByDescending(p => p.Price).ToList();
                 break;
                 case "price_asc":
                 products = products.OrderBy(p => p.Price).ToList();
                 break;
                 default:
                 break; 
             }

             Products = products.Skip((PageNum - 1) * PageSize).Take(PageSize).ToList();

        }
    }
}
