﻿

using System.Linq.Expressions;

namespace RestaurantePro.Common.Data.Repository
{
    /// <summary>
    /// Interfaces base para los repositorios
    /// </summary>
    /// <typeparam name="TEntity">Entidad con la que se va a trabajar   </typeparam>
    /// <typeparam name="TType">Id por donde se va a buscar</typeparam>
    public  interface IBaseRepository<TEntity, TType> where  TEntity : class
    {
        ///
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        List<TEntity> GetAll();

        TEntity GetEntityBy(TType Id);

        bool Exists (Expression<Func<TEntity, bool>> filter);
    }
}
