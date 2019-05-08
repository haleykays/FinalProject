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
    public class FaceModel : PageModel
    {
        private readonly MakeupProject.Models.MakeupProjectDbContext _context;

        public FaceModel(MakeupProject.Models.MakeupProjectDbContext context)
        {
            _context = context; 
        }
        public List<MakeupProject.Models.Products> faceProduct {get; set;}

        public void OnGet()
        {
            faceProduct = _context.Product.Include(p => p.Reviews).Where(p => p.Type == "Face").ToList();
        }
    }
}