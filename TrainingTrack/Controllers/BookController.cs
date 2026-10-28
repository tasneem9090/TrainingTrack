using Microsoft.AspNetCore.Mvc;
using TrainingTrack.Models;
using TrainingTrack.Services;

namespace TrainingTrack.Controllers
{
    public class BookController : Controller
    {
        IBookServices bookServices;
        public BookController(IBookServices _bookServices)
        {
            bookServices = _bookServices;
        }
        public IActionResult NewBook()
        {
            return View("NewBook");
        }
        
      
        public IActionResult Save(BookModel bookModel)
        {

            bookServices.Insert(bookModel);

            return View("NewBook", bookModel);
        }
        public IActionResult BookList()
        {
            List<BookModel> bookModels = bookServices.LaadAll();
            return View(bookModels);

        }

        public IActionResult Delete(int Id)
        {
            bookServices.Delete(Id);
            List<BookModel> books = bookServices.LaadAll();
            return View("BookList", books);
        }

        public IActionResult Edit(int Id)
        {
            ViewBag.IsEdit = true;
            BookModel book = bookServices.Find(Id);
            return View("NewBook", book);
        }
        public IActionResult Updatedepart(BookModel bookModel)
        {
            bookServices.Update(bookModel);
            ViewBag.IsEdit = true;
            return View("NewBook");
        }
    }
}


