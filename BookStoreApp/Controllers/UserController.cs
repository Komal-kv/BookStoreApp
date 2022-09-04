using BusinessLayer.Interfaces;
using CommonLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookStoreApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL userBL;
        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }

        [HttpPost("Register")]
        public ActionResult UserRegister(UserPostModel model)
        {
            try
            {
                var user = this.userBL.Register(model);
                if (user != null)
                {
                    return this.Ok(new { success = true, message = "Registration Successfull", data = user });
                }
                return this.BadRequest(new { success = false, message = "Email Already Exits", data = user });
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost("LogIn")]
        public ActionResult LogIn(LogInModel log)
        {
            try
            {
                var user = this.userBL.LogIn(log);
                if (user != null)
                {
                    return this.Ok(new { success = true, message = "LogIn Successfull", data = user });
                }
                return this.BadRequest(new { success = false, message = "LogIn Failed", data = user });
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost("ForgetPassword")]
        public ActionResult ForgetPassword(string Email)
        {
            try
            {
                var password = this.userBL.ForgetPassword(Email);
                if (password != null)
                {
                    return this.Ok(new { success = true, message = "Mail has sent Successfull", data = password });
                }
                return this.BadRequest(new { success = false, message = "Enter the valid email" });
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut("ResetPassword")]
        public ActionResult ResetPassword(UserPasswordModel model, string Email)
        {
            try
            {
                var password = this.userBL.ResetPassword(model, Email);
                if (password != null)
                {
                    return this.Ok(new { success = true, message = "Reset Password has been Successfull" });
                }
                return this.BadRequest(new { success = false, message = "Reset Password failed" });
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }
    }
}
