using OnionArchitecture.Application.Interfaces.Repository;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Persistence.Context;

namespace OnionArchitecture.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
