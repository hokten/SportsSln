using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models;

public class Product
{
	public long? ProductID { get; set; }
	
	
	[Required(ErrorMessage = "Ad girmelisiniz")]
	public string Name { get; set; } = String.Empty;
	
	public string Description { get; set; } = String.Empty;
	
	[Column(TypeName = "decimal(8, 2)")]
	public decimal Price { get; set; }
	
	
	public string Category { get; set; } = String.Empty;


}
