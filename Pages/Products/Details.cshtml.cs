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
    public class DetailsModel : PageModel
    {
        private readonly MakeupProjectDbContext _context;

        public DetailsModel(MakeupProjectDbContext context)
        {
            _context = context;
        }

        public Products Products { get; set; }

        public IList<Review> Reviews {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Product.Include(p => p.Reviews).FirstOrDefaultAsync(m => m.ID == id);

            if (Products == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
