using Aplikasi;

Platform AppControl = new Platform();

string input = Console.ReadLine();
string output = Console.ReadLine();

AppControl.Login(input, output);
AppControl.Menu();