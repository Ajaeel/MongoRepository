﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace DreamSongs.MongoRepository
{
   public interface IRepository<T> where T : Entity
    {
        /// <summary>
        /// Returns the T by its given ObjectId
        /// </summary>
        /// <param name="id">The object Id</param>
        /// <returns>The Entity T</returns>
        T GetById(string id);

        /// <summary>
        /// Returns the T (1 record) by the given criteria
        /// </summary>
        /// <param name="expression">The expression</param>
        /// <returns>The T</returns>
        T GetSingle(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Retunrs the list of T where it matches the criteria
        /// </summary>
        /// <param name="expression">The expression</param>
        /// <returns>List of T</returns>
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Inserts the new item in DB
        /// </summary>
        /// <param name="item">The Item T</param>
        /// <returns>The added Item inclduing its new ObjectId</returns>
        T Insert(T item);
    }
}