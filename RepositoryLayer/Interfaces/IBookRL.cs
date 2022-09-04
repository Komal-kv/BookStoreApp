using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IBookRL
    {
        public BookPostModel AddBook(BookPostModel bookPostModel);
        public BookPostModel UpdateBook(BookPostModel bookPostModel);
        public string DeleteBook(int BookId);
        public BookPostModel GetBookById(int BookId);
        public List<GetAllBookModel> GetAllBooks();
    }
}
