using ProductMicroservice.Model;

namespace ProductMicroservice.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
