using System;
using System.Text.Json;

namespace Aplikasi
{
    public class Platform
    {
        public List<Admin> Admins;
        public List<Person> People;

        public enum SignUpState
        {
            Initial,
            CheckRun,
            Final
        };

        public Platform() 
        {
            this.Admins = new List<Admin> { new Admin("admin", "admin") };
            this.People = new List<Person>() { new Person("Walid", "walid123")};
        }

        public void SignUp(string username, string password)
        {
            SignUpState signUpState = SignUpState.Initial;
            switch (signUpState)
            {
                case SignUpState.Initial:
                    Person people = new Person(username, password);
                    People.Add(people);
                    signUpState = SignUpState.CheckRun;
                    break;
                case SignUpState.CheckRun:
                    for(int i = 0; i < People.Count;i++)
                    {
                        if(username == People[i].Username)
                        {
                            Console.WriteLine("Username sudah ada");
                            People.RemoveAt(i);
                            break;
                        }
                    }
                    signUpState = SignUpState.Final;
                    break;
                case SignUpState.Final:
                    Console.WriteLine("Selamat anda berhasil melakukan SignUp");
                    break;
            }

        }
        public bool Login<T>(string username, string password)
        {
            Type t = typeof(T);

            if (t == typeof(Admin))
            {
                for(int i = 0; i < Admins.Count; i++)
                {
                    if (username.Equals(Admins[i].Username) && password.Equals(Admins[i].Password))
                    {
                        Console.WriteLine("Login berhasil Sebagai Admin");
                        return true;
                    }
                }
                return false;
            }
            else if (t == typeof(Person))
            {
                for (int i = 0; i < People.Count; i++)
                {
                    if (username.Equals(People[i].Username) && password.Equals(People[i].Password))
                    {
                        Console.WriteLine("Login berhasil");
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
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

            if(input < Menu.Length)
            {
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
            else
            {
                Console.WriteLine("Inputan tidak Valid");
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
            
            if(input < Menu.Length)
            {
                switch ((MenuOption1)input)
                {
                    case MenuOption1.SignUp:
                        Console.WriteLine("Masukan Username anda : ");
                        string input1 = Console.ReadLine();
                        Console.WriteLine("Masukan Password anda : ");
                        string input2 = Console.ReadLine();
                        SignUp(input1, input2);
                        break;

                    case MenuOption1.LogIn:
                        Console.WriteLine("Masukan Username anda : ");
                        input1 = Console.ReadLine();
                        Console.WriteLine("Masukan Password anda : ");
                        input2 = Console.ReadLine();
                        Console.WriteLine("LogIn sebagai (Admin/Person) : ");
                        Console.WriteLine("LogIn sebagai (Admin/Person) : ");
                        string loginType = Console.ReadLine();

                        if (loginType == "Admin")
                        {
                            Login<Admin>(input1, input2);
                        }
                        else if (loginType == "Person")
                        {
                            Login<Person>(input1, input2);
                        }
                        else
                        {
                            Console.WriteLine("Tipe login tidak valid.");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Inputan Tidak Valid");
            }
        }
    }
}
