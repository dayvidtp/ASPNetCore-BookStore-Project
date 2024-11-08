using Bookstore.Data;
using Bookstore.Models;

namespace Bookstore.Services
{
    public class GenreService
    {
        private readonly BookstoreContext _context;
        public GenreService(BookstoreContext context)
        {
            _context = context;
        }
        public List<Genre> FindAll()
        {
            return _context.Genres.ToList();
        }
        public void Insert(Genre genre)
        {
            _context.Add(genre);
            _context.SaveChanges();
        }
    }
}
