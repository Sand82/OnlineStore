﻿using System.Linq.Expressions;

namespace OnlineStore.Data.Common
{
    public interface IGenericRepository<T> where T : class
    {       
        Task<IEnumerable<T>> GetAllAsync();      

        Task<T> GetByIdAsync(int id); 

        Task AddAsync(T entity);

        void Update(T entity);

        Task DeleteAsync(int id);
        
        Task<int> SaveAsync();
    }
}
