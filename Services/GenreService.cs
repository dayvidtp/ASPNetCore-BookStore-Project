using Biblioteca.Controllers;
using Bookstore.Data;
using Bookstore.Models;
using Bookstore.Services.Exceptions;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Services
{
    public class GenreService
    {
        private readonly BookstoreContext _context;
        public GenreService(BookstoreContext context)
        {
            _context = context;
        }
        public async Task<List<Genre>> FindAllAsync() => await _context.Genres.ToListAsync();
   
        public async Task InsertAsync(Genre genre)
        {
            _context.Add(genre);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                Genre genre = await _context.Genres.FindAsync(id);
                _context.Genres.Remove(genre);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new IntegrityException(ex.Message);
            }
        }

        public async Task<Genre> FindByIdAsync(int id) => await _context.Genres.FindAsync(id);   
    }
}
