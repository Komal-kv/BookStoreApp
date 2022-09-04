using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.WishList
{
    public class WishListModel
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int WishListId { get; set; }
        public BookPostModel book { get; set; }
    }
}
