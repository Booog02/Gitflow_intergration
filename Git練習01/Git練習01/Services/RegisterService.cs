using Git練習01.Models;

namespace Git練習01.Services
{
    public class RegisterService
    {
        public bool UserRegist(RegisterModel model)
        {
            UserModel userModel = new UserModel();
            userModel.Account = model.Account;
            userModel.Password = model.Password;
            return true;
        }
    }
}