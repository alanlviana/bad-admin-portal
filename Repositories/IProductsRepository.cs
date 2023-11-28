using bad_admin.Models;

public interface IProductsRepository{
    public Task<IList<Product>> SearchProducts(string productName);
}