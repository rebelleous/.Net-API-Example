using AlphaStellar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar.Services
{
    public interface IGenericService<TEntity> where TEntity : Vehicle
    {
        Task Create(TEntity entity);
        IQueryable<TEntity> GetAll();
        Task Update(int id, TEntity entity);
        Task Delete(int id);
        Task<TEntity> GetById(int id);
        IQueryable<TEntity> GetAllByColor(string Color);



    }
}