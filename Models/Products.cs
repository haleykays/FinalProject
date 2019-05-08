using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MakeupProject.Models
{
    public class Products
    {
        [Display(Name ="Products")]
        public int ID {get; set;}
        [Required]
        public string Brand {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price {get; set;} 
        [Required]
        [Display(Name = "Purchase At")]
        public string BuyAt {get; set;}
        [Required]
        public string Type {get; set;}
        public List<Review> Reviews {get; set;}
    }
}