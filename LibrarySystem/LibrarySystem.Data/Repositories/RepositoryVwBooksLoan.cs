using LibrarySystem.Data.Interfaces;
using LibrarySystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Repositories
{
	public class RepositoryVwBooksLoan : RepositoryBase<VwBooksLoan>, IRepositoryVwBooksLoan
	{
		public RepositoryVwBooksLoan(bool saveChanges = true) : base(saveChanges)
		{
		}
	}
}
