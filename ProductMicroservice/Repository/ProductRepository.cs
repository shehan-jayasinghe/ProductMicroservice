using ProductMicroservice.DBContexts;
using ProductMicroservice.Model;
using ProductMicroservice.Repository.IRepository;

namespace ProductMicroservice.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ProductContext _db;
        public ProductRepository(ProductContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product Obj)
        {
            _db.Products.Update(Obj);
        }
    }
}
