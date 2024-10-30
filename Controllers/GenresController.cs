using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            List<Genre> genres = new List<Genre>
            {
                new Genre
                {
                    Id = 1,
                    Name = "Romance"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Horror"
                }
            };

            return View(genres);
        }
    }
}
