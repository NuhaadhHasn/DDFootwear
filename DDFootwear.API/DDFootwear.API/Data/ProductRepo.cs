using DDFootwear.API.Model;

namespace DDFootwear.API.Data
{
    public class ProductRepo : IProductRepo
    {
        private AppDbContext _dbContext;

        public ProductRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Save()
        {
            int count = _dbContext.SaveChanges();
            if (count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public Product GetProduct(int id)
        {
            return _dbContext.Products.FirstOrDefault(product => product.ProductId == id);
        }

        public bool UpdateProduct(Product product)
        {
            if (product != null)
            {
                _dbContext.Products.Update(product);
                return Save();
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProduct(Product product)
        {
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                return Save();
            }
            else
            {
                return false;
            }
        }

        public bool CreateProduct(Product product)
        {
            if (product != null)
            {
                _dbContext.Products.Add(product);
                return Save();
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Product> GetProduct()
        {
            return _dbContext.Products.ToList();
        }

    }
}
