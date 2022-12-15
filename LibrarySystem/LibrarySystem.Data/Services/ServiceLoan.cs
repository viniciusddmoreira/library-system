using LibrarySystem.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Services
{
    public class ServiceLoan
    {
        public RepositoryVwBooksLoan RepositoryVwBooksLoanProp { get; set; }
        public RepositoryBook RepositoryBookProp { get; set; }
        public RepositoryCustomer RepositoryCustomerProp { get; set; }
        public RepositoryBooksLoan RepositoryBooksLoanProp { get; set; }

        public ServiceLoan()
        {
            RepositoryVwBooksLoanProp = new RepositoryVwBooksLoan();
			RepositoryBookProp = new RepositoryBook();
			RepositoryCustomerProp = new RepositoryCustomer();
			RepositoryBooksLoanProp = new RepositoryBooksLoan();

		}
    }
}
