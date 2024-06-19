using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class QuoteController : Controller
    {
        public static List<Quote> quotes = new List<Quote>();
        public static Random random = new Random();

        //Начальная страница
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        // отображение текущего дня
        [HttpGet("/today")]
        public IActionResult Today()
        {
            ViewData["Today"] = DateTime.Now.ToString("D");
            return View();
        }

        //добавление цитаты
        [HttpGet("/add")]
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost("/add")]
        public IActionResult Add(Quote quote)
        {
            if (ModelState.IsValid)
            {
                quote.Id = quotes.Count + 1;
                quote.DateAdded = DateTime.Now;
                quotes.Add(quote);
                return RedirectToAction("Index");
            }
            return View(quote);
        }

        //сдучайная цитата
        [HttpGet("/quote")]
        public IActionResult RandomQuote()
        {
            if(quotes.Count == 0)
            {
                return View("NoQuotes");
            }
            var randomQuote = quotes[random.Next(quotes.Count)];
            return View(randomQuote);
        }
    }
}
