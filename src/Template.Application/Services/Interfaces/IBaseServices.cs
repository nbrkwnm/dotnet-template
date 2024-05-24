using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Application.Services.Interfaces
{
    public interface IBaseServices<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task<IList<TEntity>> GetAll();
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task DeleteById(int id);
    }
}
