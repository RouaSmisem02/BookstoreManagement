namespace BookstoreManagement.Models
{
	public class Book
	{
		public int BookId { get; set; } // Ensure this is a property
		public string Title { get; set; } = string.Empty; // Default value to avoid null warnings
		public string Author { get; set; } = string.Empty; // Default value to avoid null warnings
		public decimal Price { get; set; } // Assuming Price is a decimal
		public string Genre { get; set; } = string.Empty; // Default value to avoid null warnings
	}
}