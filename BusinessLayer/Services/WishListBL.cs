using BusinessLayer.Interfaces;
using CommonLayer.WishList;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class WishListBL : IWishListBL
    {
        private readonly IWishListRL wishList;
        public WishListBL(IWishListRL wishList)
        {
            this.wishList = wishList;
        }

        public WishListModel AddWishList(WishListModel wish, int UserId)
        {
            try
            {
                return this.wishList.AddWishList(wish, UserId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string DeleteWishList(int WishListId, int UserId)
        {
            try
            {
                return this.wishList.DeleteWishList(WishListId, UserId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<WishListModel> GetWishList(int UserId)
        {
            try
            {
                return this.wishList.GetWishList(UserId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
