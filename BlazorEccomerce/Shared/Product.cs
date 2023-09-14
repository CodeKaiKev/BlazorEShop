using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEccomerce.Shared
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        //New Properties
        public int? ReleaseYear { get; set; }
        public string? Developer { get; set; }

        

        
    }
}
