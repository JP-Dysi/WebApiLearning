using System.ComponentModel.DataAnnotations;

namespace WebApiApp.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(20)]
		public string Name { get; set; }

		[Required]
		public string Category { get; set; }
		
		[Required]
		[Range(0.01d, 9999d)]
		public decimal Price { get; set; }
	}
}