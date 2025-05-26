using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;
using WinFormsApp1.Objects;

// LoginService.cs
// LoginService.cs
public class LoginService
{
    //Tolu

   // private readonly DbReadLogin _dbReadLogin; 


    public async Task<bool> AuthenticateAsync(string username, string password)
    {
        string? storedHash = await Program.dbServices.DbReadLogin.GetPasswordHashByUsernameAsync(username);

        if (string.IsNullOrEmpty(storedHash))
        {
            Console.WriteLine($"Login failed - unknown user: {username}");
            return false;
        }

        bool isValid = PasswordHelper.VerifyPassword(password, storedHash);

        if (!isValid)
            Console.WriteLine($"Login failed - wrong password for user: {username}"); 

        return isValid;
    }
}
