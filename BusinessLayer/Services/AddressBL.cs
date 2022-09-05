using BusinessLayer.Interfaces;
using CommonLayer.Model;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class AddressBL : IAddressBL
    {
        private readonly IAddressRL addressRL;
        public AddressBL(IAddressRL addressRL)
        {
            this.addressRL = addressRL;
        }

        public string AddAddress(AddressModel address, int UserId)
        {
            try
            {
                return this.addressRL.AddAddress(address, UserId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteAddress(int AddressId, int UserId)
        {
            try
            {
                return this.addressRL.DeleteAddress(AddressId, UserId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public AddressModel GetAddress(int AddressId, int UserId)
        {
            try
            {
                return this.addressRL.GetAddress(AddressId, UserId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public AddressModel UpdateAddress(AddressModel address, int UserId)
        {
            try
            {
                return this.addressRL.UpdateAddress(address, UserId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
