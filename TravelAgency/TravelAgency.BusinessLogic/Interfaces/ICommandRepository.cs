using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.BusinessLogic.Models;

namespace TravelAgency.BusinessLogic.Interfaces
{
    public interface ICommandRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

    }
}
