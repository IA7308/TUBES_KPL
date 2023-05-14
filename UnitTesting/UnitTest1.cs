using Aplikasi;
using Alokasi;
using NEWS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SignUp_ShouldAddNewUser()
        {
            // Arrange
            Platform platform = new Platform();
            string username = "testuser";
            string password = "testpassword";
            Person p = new Person(username, password);
            // Act
            platform.SignUp(username, password);

            // Assert
            Assert.AreEqual(platform.People.Contains(p), platform.People.Contains(p));
        }

        [TestMethod]
        public void Login_Admin()
        {
            Platform platform = new Platform();
            string username = "admin";
            string password = "admin";
            Admin p = new Admin(username, password);
            // Act
            platform.Login<Admin>(username, password);

            // Assert
            Assert.AreEqual(true, platform.Login<Admin>(username, password));
        }

        [TestMethod]
        public void FailLogin_Admin()
        {
            Platform platform = new Platform();
            string username = "123";
            string password = "4123";
            Admin p = new Admin(username, password);
            // Act
            platform.Login<Admin>(username, password);

            // Assert
            Assert.AreEqual(false, platform.Login<Admin>(username, password));
        }

        [TestMethod]
        public void Login_User()
        {
            Platform platform = new Platform();
            string username = "Walid";
            string password = "walid123";
            Person p = new Person(username, password);
            // Act
            platform.Login<Person>(username, password);

            // Assert
            Assert.AreEqual(true, platform.Login<Person>(username, password));
        }
        
        [TestMethod]
        public void FailLogin_User()
        {
            Platform platform = new Platform();
            string username = "123";
            string password = "4123";
            Person p = new Person(username, password);
            // Act
            platform.Login<Person>(username, password);

            // Assert
            Assert.AreEqual(false, platform.Login<Person>(username, password));
        }

        [TestMethod]
        public void TestPenempatan()
        {
            // Arrange
            string tempat = "Jalan Sudirman";
            string waktu = "08:00";

            // Act
            string result = Alokasi.Alokasi.Penempatan(tempat, waktu);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}