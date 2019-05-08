using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MakeupProject.Models
{
    public class Review
    {
        [Display(Name = "Products")]
        public int ID {get; set;}
        [Range(1, 5)]
        public int Stars {get; set;}
        [StringLength(250)]
        public string ReviewText {get; set;}

        public int ProductsID {get; set;}
        public Products Products {get; set;}
    }
    
}