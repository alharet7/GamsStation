using App.DataAccess.Data;
using App.DataAccess.Repository.IRepository;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private ApplicationDbContext _db;
		private readonly IConfiguration _configuration;
		private readonly string _azueConnection;
		public ICategoryRepository Category { get; private set; }
		public IGameRepository Game { get; private set; }
		public ICompanyRepository Company { get; private set; }
		public IShoppingCartRepository ShoppingCart { get; private set; }
		public IApplicationUserRepository ApplicationUser { get; private set; }
		public IOrderHeaderRepository OrderHeader { get; private set; }
		public IOrderDetailRepository OrderDetail { get; private set; }
		public UnitOfWork(ApplicationDbContext db, IConfiguration configuration)
		{
			_db = db;
			ShoppingCart = new ShoppingCartRepository(_db);
			Category = new CategoryRepository(_db);
			Game = new GameRepository(_db);
			Company = new CompanyRepository(_db);
			OrderHeader = new OrderHeaderRepository(_db);
			OrderDetail = new OrderDetailRepository(_db);
			ApplicationUser = new ApplicationUserRepository(_db);
			_configuration = configuration;
			_azueConnection = _configuration.GetConnectionString("AzureConnectionStrings");
		}

		public void Save()
		{
			_db.SaveChanges();
		}

		public string UploadImage(IFormFile file)
		{
			BlobContainerClient blobContainer = new(_azueConnection, "gamsstation");
			blobContainer.CreateIfNotExistsAsync();
			BlobClient blobClient = blobContainer.GetBlobClient(file.FileName);
			using var stream = file.OpenReadStream();
			BlobUploadOptions blobUploadOptions = new BlobUploadOptions
			{
				HttpHeaders = new BlobHttpHeaders { ContentType = file.ContentType }
			};
			if (!blobClient.Exists())
			{
				blobClient.Upload(stream, blobUploadOptions);
			}
			return blobClient.Uri.ToString();
		}
	}
}
