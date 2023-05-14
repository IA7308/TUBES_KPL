using System.Text.Json;
using System.IO;

public class SignUp
{
    public string SuccessMessage { get; set; }
    public string AccountCreatedMessage { get; set; }

    public SignUp(string successMessage, string accountCreatedMessage)
    {
        SuccessMessage = successMessage;
        AccountCreatedMessage = accountCreatedMessage;
    }

}
