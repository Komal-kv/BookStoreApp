using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IAddressRL
    {
        public string AddAddress(AddressModel address, int UserId);
        public AddressModel UpdateAddress(AddressModel address, int UserId);
        public bool DeleteAddress(int AddressId, int UserId);
        public AddressModel GetAddress(int AddressId, int UserId);
    }
}
