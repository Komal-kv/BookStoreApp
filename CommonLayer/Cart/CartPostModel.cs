using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Cart
{
    public class CartPostModel
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int BookQuantity { get; set; }
        public BookPostModel bookPost { get; set; }
    }
}
