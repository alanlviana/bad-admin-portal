using bad_admin.Models;

public interface IUsersRepository{
    public Task<User?> GetUserByUsernameAndPassword(string username, string password);
}