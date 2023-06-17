using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFrame
{
    public interface IController
    {
        void Login(string username, string password);
        void SignUp(string username, string password);
        void Registrasi();
    }
}
