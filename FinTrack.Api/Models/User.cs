namespace FinTrack.Models;

public class User
{
    public User(string userName, string login, string password)
    {
        UserName = userName;
        Login = login;
        Password = password;
    }
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public ICollection<Budget>? Budgets { get; set; }

}
