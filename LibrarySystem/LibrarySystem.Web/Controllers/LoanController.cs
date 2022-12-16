using LibrarySystem.Data.Models;
using LibrarySystem.Data.Services;
using LibrarySystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Web.Controllers
{
	public class LoanController : Controller
	{
		private ServiceLoan _serviceLoan = new ServiceLoan();
		public IActionResult Index()
		{
			List<VwBooksLoan> listVwBooksLoan = _serviceLoan.RepositoryVwBooksLoanProp.GetAll();

			return View(listVwBooksLoan);
		}

		public IActionResult Create()
		{
			LoanViewModel loanViewModel = new LoanViewModel();
			List<Book> listBook = _serviceLoan.RepositoryBookProp.GetAll();
			List<Customer> listCustomer = _serviceLoan.RepositoryCustomerProp.GetAll();

			loanViewModel.ListBook = listBook;
			loanViewModel.ListCustomer = listCustomer;

			loanViewModel.LoanDate = DateTime.Now;
			loanViewModel.DeliveryDate = DateTime.Now.AddDays(7);		

			return View(loanViewModel);
		}

		[HttpPost]
		public IActionResult Create(LoanViewModel loanViewModel)
		{
			BooksLoan booksLoan = new BooksLoan();
			booksLoan.BookId = loanViewModel.BookId;
			booksLoan.CustomerId = loanViewModel.CustomerId;
			booksLoan.LoanDate = loanViewModel.LoanDate;
			booksLoan.DeliveryDate = loanViewModel.DeliveryDate;
			booksLoan.Returned = false;

			_serviceLoan.RepositoryBooksLoanProp.Include(booksLoan);

			return RedirectToAction("Index");

		}

		public IActionResult Details(int id)
		{
			VwBooksLoan vwBooksLoan = _serviceLoan.RepositoryVwBooksLoanProp.GetPrimaryKey(id);

			return View(vwBooksLoan);
		}

		public IActionResult Edit(int id) 
		{		
			BooksLoan booksLoan = _serviceLoan.RepositoryBooksLoanProp.GetPrimaryKey(id);

			return View(booksLoan);
		}

		[HttpPost]
		public IActionResult Edit(BooksLoan booksLoan)
		{
			if (ModelState.IsValid)
			{
				BooksLoan editBooksLoan = _serviceLoan.RepositoryBooksLoanProp.Edit(booksLoan);
				return RedirectToAction("Index");
			}

			return View();
		}
    }
}
