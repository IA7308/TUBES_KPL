using System;

namespace Aplikasi
{
    public class Platform
    {
        public List<Admin> Admins = new List<Admin> { new Admin("admin", "admin") };
        public List<Person> People = new List<Person>();

        public bool Login(string username, string password)
        {
            LoginState currentState = LoginState.Initial;
            int adminIndex = 0;
            int peopleIndex = 0;

            while (true)
            {
                switch (currentState)
                {
                    case LoginState.Initial:
                        if (adminIndex < Admins.Count)
                        {
                            if (Admins[adminIndex].Username == username && Admins[adminIndex].Password == password)
                            {
                                Console.WriteLine("Log-In anda berhasil sebagai Admin!");
                                return true;
                            }
                            adminIndex++;
                        }
                        currentState = LoginState.PeopleCheck;
                        break;
                    case LoginState.PeopleCheck:
                        if (peopleIndex < People.Count)
                        {
                            if (People[peopleIndex].Username == username && People[peopleIndex].Password == password)
                            {
                                Console.WriteLine("Log-In anda berhasil!");
                                return true;
                            }
                            peopleIndex++;
                        }
                        currentState = LoginState.Final;
                        break;
                    case LoginState.Final:
                        return false;
                }
            }
        }

        public enum LoginState
        {
            Initial,
            PeopleCheck,
            Final
        }


        public void SignUp(string username, string password)
        {
            Person person = new Person(username, password);
            People.Add(person);

            // Membaca konfigurasi dari file JSON
            SignUpConfig configuration = SignUpConfig.LoadSignUpConfig("json1.json");

            Console.WriteLine(configuration.SuccessMessage);
            Console.WriteLine(configuration.AccountCreatedMessage);
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

            for (int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine(i + ". " + Menu[i].ToString());
            }

            Console.WriteLine("Pilih Menu : ");
            int input = int.Parse(Console.ReadLine());

            switch ((MenuOption)input)
            {
                case MenuOption.News:
                    Console.WriteLine("TEKS NEWS");
                    break;
                case MenuOption.Alokasi:
                    //Console.WriteLine("Teks Alokasi");
                    Console.WriteLine("Masukan tempat penjemputan : ");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Masukan waktu penjemputan : ");
                    string input2 = Console.ReadLine();

                    Console.WriteLine(Alokasi.Alokasi.Penempatan(input1, input2));
                    break;
            }

        }

        enum MenuOption1
        {
            SignUp, LogIn
        };
        public void MenuRegis()
        {
            MenuOption1[] Menu =
            {
                 MenuOption1.SignUp,
                 MenuOption1.LogIn
            };

            for (int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine(i + ". " + Menu[i].ToString());
            }
            Console.WriteLine("Pilih Menu : ");
            int input = int.Parse(Console.ReadLine());

            switch ((MenuOption1)input)
            {
                case MenuOption1.SignUp:
                    Console.WriteLine("Masukan Username anda : ");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Masukan Password anda : ");
                    string input2 = Console.ReadLine();
                    SignUp(input1, input2);

                    //Platform app = new Platform();
                    //app.SignUp(input1, input2);

                    break;
                case MenuOption1.LogIn:
                    Console.WriteLine("Masukan Username anda : ");
                    input1 = Console.ReadLine();
                    Console.WriteLine("Masukan Password anda : ");
                    input2 = Console.ReadLine();
                    Login(input1, input2);

                    //app = new Platform();
                    //app.Login(input1, input2);

                    break;
            }

        }
    }
}
