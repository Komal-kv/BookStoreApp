using BusinessLayer.Interfaces;
using CommonLayer.Admin;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminBL adminBL;
        public AdminController(IAdminBL adminBL)
        {
            this.adminBL = adminBL;
        }

        [HttpPost("LogIn")]
        public ActionResult AdminLogIn(AdminLoginModel admin)
        {
            try
            {
                var user = this.adminBL.AdminLogIn(admin);

                if (user != null)
                {
                    return Ok(new { success = true, message = "Login done sucessfully", data = user });
                }
                else
                    return BadRequest(new { success = false, message = "Failed to Login" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
