using ProductMicroservice.Model;

namespace ProductMicroservice.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    { 
        void Update(Category category);
    }
}
