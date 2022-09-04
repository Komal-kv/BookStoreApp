using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IUserBL
    {
        public UserPostModel Register(UserPostModel model);
        public LogInModel LogIn(LogInModel log);
        public string ForgetPassword(string Email);
        public string ResetPassword(UserPasswordModel user1, string Email);
    }
}
