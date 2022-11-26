using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MitalisBooks.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [Range(1, 1000)]
        public double ListPrice { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int CoverTypeId { get; set; }
        [ForeignKey("CoverTypeId")]
        public CoverType CoverType { get; set; }
    }
}
