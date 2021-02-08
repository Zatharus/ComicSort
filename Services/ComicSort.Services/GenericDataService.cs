
using ComicSort.Data.Models;
using ComicSort.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComicSort.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        public Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(Guid id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
