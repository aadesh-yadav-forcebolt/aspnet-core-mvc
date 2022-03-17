using BookStoreProject.Models;
using BookStoreProject.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            //return "['book1','book2','book3']";
            var data = _bookRepository.GetAllBooks();
            return View();
        }

        public dynamic GetBook(int id)
        {
            //return $"book id = {id}";
            return _bookRepository.GetBookById(id);
        }
        public dynamic SearchBook(string BookName,string AuthorName)
        {
            //return $"Searched book with Book Name = {BookName} and Author Name = {AuthorName}";
            return _bookRepository.SearchBook(BookName, AuthorName);
        }
    }
}
