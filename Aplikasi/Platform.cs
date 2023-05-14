namespace Aplikasi
{
    public class Platform
    {
        public List<Admin> Admins = new List<Admin> { new Admin("admin", "admin") };
        public List<Person> People { get; set; }


        public bool Login(string username, string password)
        {
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].Username == username && Admins[i].Password == password)
                {
                    return true;
                }
            }
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Username == username && People[i].Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public void SignUp(string username, string password)
        {
            Person person = new Person(username, password);
            People.Add(person);
        }

        enum MenuOption
        {
            News, Alokasi
        };

        public void Menu()
        {
            MenuOption[] Menu =
            {
                 MenuOption.News,
                 MenuOption.Alokasi
            };

            for (int i = 0; i<Menu.Length; i++)
            {
                Console.WriteLine(i + ". " + Menu[i].ToString());
            }
            
            int input = int.Parse(Console.ReadLine());

            switch ((MenuOption)input)
            {
                case MenuOption.News:
                    Console.WriteLine("TEKS NEWS");
                    break;
                case MenuOption.Alokasi:
                    Console.WriteLine("Teks Alokasi");
                    break;
            }

        }

    }
}