namespace Aplikasi
{
    public class Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Person(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
