using BookStoreProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public dynamic GetBookById(int id)
        {
            List<BookModel> books = DataSource();
            dynamic book = from b in books where b.Id == id select b;
            return book;

        }

        public dynamic SearchBook(string title, string authorName)
        {
            List<BookModel> books = DataSource();
            dynamic book = from b in books where b.Title.Contains(title) || b.Author.Contains(authorName) select b;
            return book;
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title ="C#",Author="Manish"},
                new BookModel(){Id = 2, Title ="MVC",Author="Ram"},
                new BookModel(){Id = 2, Title ="node js",Author="Ram"},
                new BookModel(){Id = 3, Title ="dotnet",Author="Anuj"},
                new BookModel(){Id = 3, Title ="dotnet",Author="shyam"},
                new BookModel(){Id = 4, Title ="Asp.net",Author="Abhishek"},
                new BookModel(){Id = 5, Title ="Data structure",Author="Aadesh"},
                new BookModel(){Id = 6, Title ="Java",Author="Shivam"},
            };
        }
    }
}
