using System.Text.Json;
using System.IO;

public class SignUpConfig
{
    public string SuccessMessage { get; set; }
    public string AccountCreatedMessage { get; set; }

    public static SignUpConfig LoadSignUpConfig(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<SignUpConfig>(json);
    }
}
