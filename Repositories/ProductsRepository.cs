using bad_admin.Models;
using Microsoft.Data.Sqlite;

namespace bad_admin.Repositories;

public class ProductsRepository: IProductsRepository{

    private SqliteConnection _connection;
    public ProductsRepository(SqliteConnection connection)
    {
        this._connection = connection;
    }

    public async Task<IList<Product>> SearchProducts(string productName){
        try{
            _connection.Open();
            var command = _connection.CreateCommand();
            command.CommandText = "SELECT id, description, price FROM product WHERE description like '%"+productName+"%'";

            using var reader = command.ExecuteReader();
            var products = new List<Product>();
            while (reader.Read())
            {
                var product = new Product();
                product.Id = reader.GetString(0);
                product.Description = reader.GetString(1);
                product.Price = reader.GetDecimal(2);
                products.Add(product);
                        
            }
            return products;
        }finally{
            _connection.Close();
        }

    }
}