using DDFootwear.API.Model;

namespace DDFootwear.API.Data
{
    public interface IProductRepo
    {
        bool Save();

        Product GetProduct(int id);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Product product);
        bool CreateProduct(Product product);
        IEnumerable<Product> GetProduct();
    }
}
