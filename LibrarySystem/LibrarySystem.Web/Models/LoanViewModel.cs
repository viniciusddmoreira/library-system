using LibrarySystem.Data.Models;

namespace LibrarySystem.Web.Models
{
	public class LoanViewModel
	{
		public Book BookProp { get; set; }
		public Customer CustomerProp { get; set; }
		public int BookId { get; set; }
		public int CustomerId { get; set; }
		public DateTime LoanDate { get; set; }
		public DateTime DeliveryDate { get; set; }

		public List<Customer> ListCustomer { get; set; }
		public List<Book> ListBook { get; set; }
		public BooksLoan BooksLoanProp { get; set; } 

	}
}
