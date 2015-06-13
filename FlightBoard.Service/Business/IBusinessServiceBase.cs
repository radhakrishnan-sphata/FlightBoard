

using FlightBoard.Data;
using System.Linq;

namespace FlightBoard.Service.Business
{
    internal interface IBusinessServiceBase<T>
    {
        IRepository<T> _repository { get; set; }

        T Add(T entity, bool save = true);

        void Update(T entity, bool save = true);

        bool Delete(T entity, bool save = true);

        IQueryable<T> FindAll();
    }
}
