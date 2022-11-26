using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace MitalisBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {

        T Get(int id); // Retrieve a category from the database by Id

        // List of Categories based on requirements
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null // useful for foreign references
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity);     // To add an entity

        void Remove(int id);     // To remove an object or category

        void Remove(T entitiy);    // Another way to remove an object

        void RemoveRange(IEnumerable<T> entity);    // Removes a complete range to entities
    }
}
