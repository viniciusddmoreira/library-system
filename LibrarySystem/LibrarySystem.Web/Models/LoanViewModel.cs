using LibrarySystem.Data.Models;
using System.ComponentModel;

namespace LibrarySystem.Web.Models
{
	public class LoanViewModel
	{
		public Book BookProp { get; set; }
		public Customer CustomerProp { get; set; }
		public int BookId { get; set; }
		public int CustomerId { get; set; }
		[DisplayName("Data do Empréstimo")]
		public DateTime LoanDate { get; set; }
		[DisplayName("Data da Devolução")]
		public DateTime DeliveryDate { get; set; }
		public BooksLoan BooksLoanProp { get; set; }

		public List<Customer> ListCustomer { get; set; }
		public List<Book> ListBook { get; set; }

	}
}
