using Bookstore.Data;
using Bookstore.Models;
using Bookstore.Models.ViewModels;
using Bookstore.Services;
using Bookstore.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Biblioteca.Controllers
{
    public class GenresController : Controller
    {
        private readonly GenreService _service;
        public GenresController(GenreService service) 
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _service.FindAllAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _service.InsertAsync(genre);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new {message = "Não foi fornecido nenhum ID"});
            }
            Genre genre = await _service.FindByIdAsync(id.Value);
            if (genre is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Não foi encontrado nenhum ID" });
            }
            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException ex)
            {
                return RedirectToAction(nameof(Error), new {message = ex.Message});
            }
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }
            Genre genre = await _service.FindByIdAsync(id.Value);
            if (genre is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id != genre.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não condizente" });
            }

            try
            {
                await _service.UpdateAsync(genre);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException ex)
            {
                return RedirectToAction(nameof(Error), new { message = ex.Message });
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }
            var obj = await _service.FindByIdEagerAsync(id.Value);
            if (obj is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            return View(obj);

        }

        public IActionResult Error(string message)
        {
            ErrorViewModel viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
