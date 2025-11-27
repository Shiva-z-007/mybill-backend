using System.ComponentModel.DataAnnotations.Schema;

namespace MyBill.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SKU { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal? Price { get; set; }
        public int Stock { get; set; }
        public string? ImagePath { get; set; }
    }
}
