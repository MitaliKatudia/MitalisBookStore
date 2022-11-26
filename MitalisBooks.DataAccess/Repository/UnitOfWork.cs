using MitalisBooks.DataAccess.Repository.IRepository;
using MitalisBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MitalisBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork   //  Make the method public to access the class
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)   // Contructor to use the DI and inject into repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }

        public ISP_Call SP_Call { get; private set; }

        public ICoverTypeRepository CoverType { get; private set; }

        public IProductRepository Product { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()   // All changes will be saved when the  Save method is called at parent level
        {
            _db.SaveChanges();
        }

    }
}
