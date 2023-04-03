using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        string path = "D:/user.json";
        List<User> users = new List<User>()
        {
            new User()
            {
                Name = "Ali",
                Email = "Email"
            },
            new User()
            {
                Name = "Javlonbek",
                Email = "Email"
            },
            new User()
            {
                Name = "Abdurohman",
                Email = "Email"
            }
        };

        var json = JsonConvert.SerializeObject(users);
        File.WriteAllText(path, json);

        var read = File.ReadAllText(path);
        var reader = JsonConvert.DeserializeObject<List<User>>(read);
        foreach (var item in reader)
        {
            Console.WriteLine(item.Name);
        }
    }
}
class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}