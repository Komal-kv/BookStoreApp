using BusinessLayer.Interfaces;
using CommonLayer.Model;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class UserBL : IUserBL
    {
        private readonly IUserRL userRL;
        public UserBL(IUserRL userRL)
        {
            this.userRL = userRL;
        }

        public string ForgetPassword(string Email)
        {
            try
            {
                return userRL.ForgetPassword(Email);
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }

        public LogInModel LogIn(LogInModel log)
        {
            try
            {
                return userRL.LogIn(log);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public UserPostModel Register(UserPostModel model)
        {
            try
            {
                return userRL.Register(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string ResetPassword(UserPasswordModel user1, string Email)
        {
            try
            {
                return userRL.ResetPassword(user1, Email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
