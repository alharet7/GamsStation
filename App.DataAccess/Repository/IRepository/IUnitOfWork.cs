using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository.IRepository
{
	public interface IUnitOfWork
	{
		ICategoryRepository Category { get; }
		IGameRepository Game { get; }
		ICompanyRepository Company { get; }
		IShoppingCartRepository ShoppingCart { get; }
		IApplicationUserRepository ApplicationUser { get; }
		IOrderDetailRepository OrderDetail { get; }
		IOrderHeaderRepository OrderHeader { get; }

		void Save();
		string UploadImage(IFormFile file);
	}
}
