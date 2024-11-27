using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bookstore.Data;
using Bookstore.Models;
using Bookstore.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Bookstore.Models.ViewModels;
using System.Diagnostics;
using Bookstore.Services.Exceptions;

namespace Bookstore.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookService _service;

        public BooksController(BookService service)
        {
            _service = service;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            return View(await _service.FindAllAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var book = await _service.FindByIdAsync(id.Value);
            if (book is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();   
            }

            await _service.InsertAsync(book);

            return RedirectToAction(nameof(Index));
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var book = await _service.FindByIdAsync(id.Value);
            if (book is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Book book)
        {
            if (id != book.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id's não condizentes" });
            }

            if (!ModelState.IsValid) 
            {
                return View();
            }

            try
            {
                await _service.UpdateAsync(book);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException ex)
            {
               return RedirectToAction(nameof(Error), new { message = ex.Message });
            }
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var book = await _service.FindByIdAsync(id.Value);
            if (book is null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(book);
        }

        // POST: Books/Delete/5
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
                return RedirectToAction(nameof(Error), new { message = ex.Message });
            }
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
