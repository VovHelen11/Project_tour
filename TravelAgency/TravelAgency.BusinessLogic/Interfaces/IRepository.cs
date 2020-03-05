using System.Collections.Generic;
using TravelAgency.BusinessLogic.Models;

namespace TravelAgency.BusinessLogic.Interfaces
{
    public interface IRepository<TEntity> :ICommandRepository<TEntity>,IQueryRepository<TEntity> where TEntity : BaseEntity
    {

    }
}