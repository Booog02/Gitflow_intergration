using Git練習01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git練習01.Services
{
    internal class LoginService
    {
        //public bool Login(LoginModel model)
        //{
        //    return model.Name == "Boog" && model.Account == "boog02" && model.Password == "1234";
        //}

        public LoginResult Login(LoginModel model)
        {
            if (model.Account == "boog02" && model.Password == "1234")
            {
                return new LoginResult
                {
                    Success = true,
                    Message = "登入成功。"
                };
            }

            return new LoginResult
            {
                Success = false,
                Message = "帳號或密碼錯誤。"
            };
        }
    }
}
