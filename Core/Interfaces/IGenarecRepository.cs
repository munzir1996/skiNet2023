using Core.Entities;
using Core.Specification;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenarecRepository<T> where T : BaseEntity 
    {
        Task<T> GertByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAysnc();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}
