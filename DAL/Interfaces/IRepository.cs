using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        //Repository CRUD interface.

        /// <summary>
        /// Add new Entity to database table
        /// </summary>
        /// <param name="obj">Instance of entity</param>
        void Add(T obj);

        /// <summary>
        /// Get all entities from database table
        /// </summary>
        /// <returns>List of entities</returns>
        List<T> GetAll();

        /// <summary>
        /// Get entity by primary key
        /// </summary>
        /// <param name="id">Primary key as integer</param>
        /// <returns>Instance of entity</returns>
        T Get(int id);

        /// <summary>
        /// Update entity in database
        /// </summary>
        /// <param name="obj">Instance of updated entity</param>
        void Update(T obj);

        /// <summary>
        /// Delete entity in database
        /// </summary>
        /// <param name="id">Primary key of entity to be deleted</param>
        void Delete(int id);

        /// <summary>
        /// Delete entity in database
        /// </summary>
        /// <param name="obj">Instance of entity</param>
        void Delete(T obj);
    }
}