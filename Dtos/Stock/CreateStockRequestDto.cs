using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
      [Required]
      [MaxLength(10, ErrorMessage = "Symbol cannot exceed 10 characters.")]
      public string Symbol { get; set; } = string.Empty;
      [Required]
      [MaxLength(10, ErrorMessage = "Company Name cannot exceed 10 characters.")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
      [Range(1,1000000000000, ErrorMessage = "Purchase price must be between 1 and 1.000.000.000.000")]
        public decimal Purchase { get; set; }
    [Required]
        [Range(0.0001,100, ErrorMessage = "Quantity must be between 0.0001 and 100")]
        public decimal LastDiv { get; set; }
    [Required]
        [MaxLength(10,ErrorMessage ="Industry cannot exceed 10 characters.")]
        public string Industry { get; set; } = string.Empty;
    [Required]
        [Range(1,5000000000000, ErrorMessage = "Market Cap must be between 1 and 5 trillion")]
        public long MarketCap { get; set; }
    }
}