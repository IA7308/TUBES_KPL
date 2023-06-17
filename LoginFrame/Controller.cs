using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFrame
{
    public class Controller : IController
    {
        public List<Admin> Admins;
        public List<Person> People;
        public Login frameLogin;
        public NEWS frameNEWS;
        public SignUpFrame frameSignUp;
        public enum SignUpState
        {
            Initial,
            CheckRun,
            Final
        };

        public Controller()
        {
            this.Admins = new List<Admin> { new Admin("admin", "admin") };
            this.People = new List<Person>() { new Person("Walid", "walid123") };
            this.frameLogin = new Login(this);
            this.frameNEWS = new NEWS(this);
            this.frameSignUp = new SignUpFrame(this);
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
                    for (int i = 0; i < People.Count; i++)
                    {
                        if (username == People[i].Username)
                        {
                            MessageBox.Show("Username Sudah Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            People.RemoveAt(i);
                            break;
                        }
                    }
                    signUpState = SignUpState.Final;
                    break;
                case SignUpState.Final:
                    MessageBox.Show("Selamat anda berhasil melakukan SignUp", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.frameLogin.Visible = true;
                    this.frameSignUp.Hide();
                    break;
            }

        }
        public bool Login<T>(string username, string password)
        {
            Type t = typeof(T);

            if (t == typeof(Admin))
            {
                for (int i = 0; i < Admins.Count; i++)
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
    

        public void Login(string username, string password)
        {
            if(username == "admin" && password == "admin")
            {
                bool loginStatus = Login<Admin>(username, password);
                if (loginStatus)
                {
                    this.frameNEWS.Visible = true;
                    this.frameLogin.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                bool loginStatus = Login<Person>(username, password);
                if(loginStatus)
                {
                    this.frameNEWS.Visible = true;
                    this.frameLogin.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Registrasi()
        {
            this.frameSignUp.Visible = true;
            this.frameLogin.Hide();
        }

    }
}
