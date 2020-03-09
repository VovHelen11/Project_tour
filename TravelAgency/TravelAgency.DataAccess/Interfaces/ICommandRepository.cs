using TravelAgency.DataAccess.Models;

namespace TravelAgency.DataAccess.Interfaces
{
    public interface ICommandRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

    }
}
