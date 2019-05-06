using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MakeupProject.Models;

namespace MakeupProject.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly MakeupProjectContext _context;

        public IndexModel(MakeupProjectContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
