using MitalisBooks.DataAccess.Repository.IRepository;
using MitalisBooks.Models;
using MitalisBookStore.DataAccess.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MitalisBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // throw new NotImplementedException();
            // Use .NET LNQ to retrieve the first or default category object
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)  // Save changes if not null
            {
                objFromDb.Name = category.Name;
                /* _db.SaveChanges();*/  // removed as per ppt
            }
        }
    }
}
