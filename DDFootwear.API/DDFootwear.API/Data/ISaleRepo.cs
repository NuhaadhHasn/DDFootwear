using DDFootwear.API.Model;

namespace DDFootwear.API.Data
{
    public interface ISaleRepo
    {
        bool Save();

        Sale GetSale(int id);
        bool UpdateSale(Sale sale);
        bool DeleteSale(Sale sale);
        bool CreateSale(Sale sale);
        IEnumerable<Sale> GetSale();
    }
}
