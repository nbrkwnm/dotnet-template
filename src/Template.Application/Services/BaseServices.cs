using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Application.Services.Interfaces;
using Template.Domain.Interfaces;
using Template.Domain.Models;

namespace Template.Application.Services
{
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : BaseModel
    {
        private readonly IBaseRepository<TEntity> _repository;
        public BaseServices(IBaseRepository<TEntity> repository)
        {
              _repository = repository;
        }

        public async Task Create(TEntity entity)
        {
            await _repository.Create(entity);
        }

        public async Task DeleteById(int id)
        {
            await _repository.DeleteById(id);
        }

        public async Task<IList<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(TEntity entity)
        {
            await _repository.Update(entity);
        }
    }
}
