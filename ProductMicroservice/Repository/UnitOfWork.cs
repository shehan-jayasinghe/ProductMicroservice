using ProductMicroservice.DBContexts;
using ProductMicroservice.Repository.IRepository;

namespace ProductMicroservice.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProductContext _db;
        public ICategoryRepository CategoryRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }


        public UnitOfWork(ProductContext db)
        {
            _db = db;
            CategoryRepository = new CategoryRepository(_db);
            ProductRepository = new ProductRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
