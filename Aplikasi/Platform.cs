using System;

namespace Aplikasi
{
    public class Platform
    {
        public List<Admin> Admins = new List<Admin> { new Admin("admin", "admin") };
        public List<Person> People = new List<Person>();


        public bool Login(string username, string password)
        {
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].Username == username && Admins[i].Password == password)
                {
                    Console.WriteLine("Log-In anda berhasil sebagai Admin!");
                    return true;
                }
            }
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Username == username && People[i].Password == password)
                {
                    Console.WriteLine("Log-In anda berhasil!");
                    return true;
                }
            }

            return false;
        }

        public void SignUp(string username, string password)
        {
            Person person = new Person(username, password);
            People.Add(person);
            Console.WriteLine("Registrasi anda berhasil!");
            Console.WriteLine("Kini anda telah mempunyai akun");
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
