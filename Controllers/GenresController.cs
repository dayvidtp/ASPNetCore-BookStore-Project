﻿using Bookstore.Data;
using Bookstore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class GenresController : Controller
    {
        private readonly GenreService _service;
        public GenresController(GenreService service) 
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(_service.FindAll());
        }
    }
}
