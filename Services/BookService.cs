using Bookstore.Data;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Services
{
    public class BookService
    {
        private readonly BookstoreContext _context;
        public BookService(BookstoreContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> FindAllAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> FindByIdAsync(int id)
        {
            return await _context.Books
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task InsertAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }
    }
}
