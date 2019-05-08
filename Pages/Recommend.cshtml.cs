using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering; 
using MakeupProject.Models;
using Microsoft.EntityFrameworkCore;

namespace MakeupProject.Pages
{
    public class RecommendModel : PageModel
    {
        private readonly MakeupProject.Models.MakeupProjectDbContext _context;

        public RecommendModel(MakeupProject.Models.MakeupProjectDbContext context)
        {
            _context = context; 
        }

        
        public List<MakeupProject.Models.Products> Product {get; set;}
        public void OnGet()
        {
        }

        public void OnPost(int[] selectedProductTypes)
        {
            Product = new List<MakeupProject.Models.Products>();

            if (selectedProductTypes.Contains(1))
            {
                // Selected Face
                var faceProduct = _context.Product.Include(p => p.Reviews).Where(p => p.Type == "Face").OrderByDescending(p => p.Reviews.Count()).FirstOrDefault();
                Product.Add(faceProduct);
            }

            if (selectedProductTypes.Contains(2))
            {
                // Selected Eyes
                var eyeProduct = _context.Product.Include(p => p.Reviews).Where(p => p.Type == "Eyes").OrderByDescending(p => p.Reviews.Count()).FirstOrDefault();
                Product.Add(eyeProduct);
            }
            if (selectedProductTypes.Contains(3))
            {
                // Selected Lips
                var lipProduct = _context.Product.Include(p => p.Reviews).Where(p => p.Type == "Lips").OrderByDescending(p => p.Reviews.Count()).FirstOrDefault();
                Product.Add(lipProduct);
            }
        }
    }
}