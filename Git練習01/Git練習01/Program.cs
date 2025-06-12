using Git練習01.Models;
using Git練習01.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Git練習01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginModel loginModel = new LoginModel()
            {
                Account = "boog",
                Password = "1234"
            };

            LoginService loginService = new LoginService();

            LoginResult loginResult = loginService.Login(loginModel);

            Console.WriteLine($"結果:{loginResult.Message}");

        }
    }
}
