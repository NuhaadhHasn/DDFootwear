using DDFootwear.API.Model;

namespace DDFootwear.API.Data
{
    public class SaleRepo : ISaleRepo
    {
        private AppDbContext _dbContext;

        public SaleRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Save()
        {
            int count = _dbContext.SaveChanges();
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Sale GetSale(int id)
        {
            return _dbContext.Sales.FirstOrDefault(sales => sales.Id == id);
        }


        public bool UpdateSale(Sale sale)
        {
            if (sale != null)
            {
                _dbContext.Sales.Update(sale);
                return Save();
            } 
            else
            {
                return false;
            }
        }

        public bool DeleteSale(Sale sale)
        {
            if (sale != null)
            {
                _dbContext.Sales.Remove(sale);
                return Save();
            }
            else
            {
                return false;
            }
        }

        public bool CreateSale(Sale sale)
        {
            if (sale != null)
            {
                _dbContext.Sales.Add(sale);
                return Save();
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Sale> GetSale()
        {
            return _dbContext.Sales.ToList();
        }
    }
}
