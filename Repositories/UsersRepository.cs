using bad_admin.Models;
using Microsoft.Data.Sqlite;

namespace bad_admin.Repositories;

public class UsersRepository: IUsersRepository{

    private SqliteConnection _connection;
    public UsersRepository(SqliteConnection connection)
    {
        this._connection = connection;
    }

    public async Task<User?> GetUserByUsernameAndPassword(string username, string password)
    {
        try{
            await _connection.OpenAsync();
            var command = _connection.CreateCommand();
            command.CommandText = "SELECT username, password FROM user WHERE username = @username and password = @password";
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            using var reader = await command.ExecuteReaderAsync();
            if (reader.Read())
            {
                var user = new User(reader.GetString(0), reader.GetString(1));
                return user;
                        
            }
            return null;
        }finally{
            await _connection.CloseAsync();
        }
    }
}