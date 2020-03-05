using System.Collections.Generic;
using TravelAgency.BusinessLogic.Models;

namespace TravelAgency.BusinessLogic.Interfaces
{
    public interface IQueryRepository<TEntity> where TEntity : BaseEntity
    {
        IReadOnlyCollection<TEntity> GetAll(int? skip = null, int? take = null);

        TEntity GetById(int id);

    }
}