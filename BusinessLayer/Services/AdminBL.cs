using BusinessLayer.Interfaces;
using CommonLayer.Admin;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class AdminBL : IAdminBL
    {
        private readonly IAdminRL adminRL;
        public AdminBL(IAdminRL adminRL)
        {
            this.adminRL = adminRL;
        }

        public AdminModel AdminLogIn(AdminLoginModel admin)
        {
            try
            {
                return this.adminRL.AdminLogIn(admin);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
