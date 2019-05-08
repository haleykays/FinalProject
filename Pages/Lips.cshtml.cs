using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MakeupProject.Models; 
using Microsoft.EntityFrameworkCore; 

namespace MakeupProject.Pages
{
    public class LipsModel : PageModel
    {
        private readonly MakeupProject.Models.MakeupProjectDbContext _context;

        public LipsModel(MakeupProject.Models.MakeupProjectDbContext context)
        {
            _context = context; 
        }
        public List<MakeupProject.Models.Products> lipProduct {get; set;}

        public void OnGet()
        {
            lipProduct = _context.Product.Include(p => p.Reviews).Where(p => p.Type == "Lips").ToList();
        }
    }
}