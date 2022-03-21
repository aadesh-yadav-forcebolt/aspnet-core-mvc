using BookStoreProject.Models;
using Newtonsoft.Json;
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

        public BookModel GetBookById(int id)
        {
            List<BookModel> books = DataSource();
            dynamic book = from b in books where b.Id == id select b;
            foreach(BookModel i in book)
            {
                return i;
            }
            return new BookModel();
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
                new BookModel(){Category="Programing",TotalPages=123,Language="Hindi",Discription = "This is the description for python book", Id = 0, Title ="python",Author="Salman"},
                new BookModel(){Category="Mythology",TotalPages=423,Language="English",Discription = "This is the description for Mvc book", Id = 1, Title ="MVC",Author="Ram"},
                new BookModel(){Category="Comedy",TotalPages=2343,Language="German",Discription = "This is the description for C# book", Id = 2, Title ="C#",Author="Manish"},
                new BookModel(){Category="Action",TotalPages=243,Language="French",Discription = "This is the description for node js book", Id = 3, Title ="node js",Author="Ram"},
                new BookModel(){Category="Programing",TotalPages=234,Language="Marathi",Discription = "This is the description for dotnet book", Id = 4, Title ="dotnet",Author="Anuj"},
                new BookModel(){Category="Mystry",TotalPages=543,Language="French",Discription = "This is the description for dotnet book", Id = 5, Title ="dotnet",Author="shyam"},
                new BookModel(){Category="Comedy",TotalPages=23432,Language="English",Discription = "This is the description for Asp.net book", Id = 6, Title ="Asp.net",Author="Abhishek"},
                new BookModel(){Category="Comedy",TotalPages=2143,Language="English",Discription = "This is the description for Data structure book", Id = 7, Title ="Data structure",Author="Aadesh"},
                new BookModel(){Category="kids",TotalPages=234,Language="Hindi",Discription = "This is the description for Java book", Id = 8, Title ="Java",Author="Shivam"},
            };
        }
    }
}
