using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MakeupProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MakeupProject.Pages_Products
{
    public class ReviewModel : PageModel
    {
        private readonly MakeupProject.Models.MakeupProjectDbContext _context;

        // The Review to add. User will input a Review Score and hit submit, so we bind this property
        [BindProperty]
        public Review Review { get; set; }

        public SelectList Products {get; set;}
        
        
        public ReviewModel(MakeupProject.Models.MakeupProjectDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
            Products = new SelectList(_context.Product.ToList(), "ID", "Brand", id);
            // I wanted to add another SelectList here like this
            //Products = new SelectList(_context.Product.ToList(), "ID", "Name", id);
            //but it still only pulls one property I'm guessing because I'm pulling from Products
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review); // Add review to database
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}