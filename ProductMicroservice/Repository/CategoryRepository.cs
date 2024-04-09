using ProductMicroservice.DBContexts;
using ProductMicroservice.Model;
using ProductMicroservice.Repository.IRepository;

namespace ProductMicroservice.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ProductContext _db;
        public CategoryRepository(ProductContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category Obj)
        {
            _db.Categories.Update(Obj);
        }
    }
}
