using System.Runtime.CompilerServices;

User user1 = new("Adam", "sa12345dwf");
User user2 = new("Monika", "sa12345dwf");
User user3 = new("Zuzia", "sa12345dwf");
User user4 = new("Damian", "sa12345dwf");

user1.AddScore(5);
user1.AddScore(32);
var result = user1.Result;
Console.WriteLine(result);

class User
{
    private List<int> score = new List<int>();
    public string Login { get; private set; }
    public string Password { get; private set; }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}