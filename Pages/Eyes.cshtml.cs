using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering; 
using MakeupProject.Models;

namespace MakeupProject.Pages
{
    public class EyesModel : PageModel
    {
        private readonly MakeupProject.Models.MakeupProjectDbContext _context;

        public EyesModel(MakeupProject.Models.MakeupProjectDbContext context)
        {
            _context = context; 
        }
        public List<MakeupProject.Models.Products> eyeProduct {get; set;}
        public void OnGet()
        {
            eyeProduct = _context.Product.Where(p => p.Type == "Eyes").ToList();
        }
    }
}