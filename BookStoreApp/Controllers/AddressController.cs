using BusinessLayer.Interfaces;
using CommonLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BookStoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressBL addressBL;
        public AddressController(IAddressBL addressBL)
        {
            this.addressBL = addressBL;
        }

        [Authorize]
        [HttpPost("AddAddress")]
        public IActionResult AddAddress(AddressModel address)
        {
            try
            {
                var currentUser = HttpContext.User;
                int UserId = Convert.ToInt32(currentUser.Claims.FirstOrDefault(c => c.Type == "UserId").Value);

                var res = this.addressBL.AddAddress(address, UserId);
                if (res != null)
                {
                    return this.Ok(new { Status = true, Message = "Added address sucessfully", Data = res });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Faild to add" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [Authorize]
        [HttpPut("UpdateAddress")]
        public IActionResult UpdateAddress(AddressModel address)
        {
            try
            {
                var currentUser = HttpContext.User;
                int UserId = Convert.ToInt32(currentUser.Claims.FirstOrDefault(c => c.Type == "UserId").Value);

                var res = this.addressBL.UpdateAddress(address, UserId);
                if (res != null)
                {
                    return this.Ok(new { Status = true, Message = "Updates address sucessfully", Data = res });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Faild to update" });
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Authorize]
        [HttpDelete("DeleteAddress")]
        public IActionResult DeleteAddress(int addressId)
        {
            try
            {
                var currentUser = HttpContext.User;
                int UserId = Convert.ToInt32(currentUser.Claims.FirstOrDefault(c => c.Type == "UserId").Value);

                var res = this.addressBL.DeleteAddress(addressId, UserId);
                if (res == true)
                {
                    return this.Ok(new { Status = true, Message = "Deleted address sucessfully", Data = res });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Faild to delete" });
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Authorize]
        [HttpGet("GetAddress")]
        public IActionResult GetAddress(int addressId)
        {
            try
            {
                var currentUser = HttpContext.User;
                int UserId = Convert.ToInt32(currentUser.Claims.FirstOrDefault(c => c.Type == "UserId").Value);

                var res = this.addressBL.GetAddress(addressId, UserId);
                if (res != null)
                {
                    return this.Ok(new { Status = true, Message = "Getting address sucessfully", Data = res });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Faild to get your address" });
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}
