using Bookstore.Data;
using Bookstore.Models;

namespace Bookstore.Services
{
    public class SeedingService
    {
        private readonly BookstoreContext _context;
        public SeedingService(BookstoreContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (_context.Genres.Any() ||
                _context.Books.Any()
                )
            {
                return;
            }
            Genre g1 = new Genre(1, "Literatura Americana");
            Genre g2 = new Genre(2, "Romance de Aventura");
            Genre g3 = new Genre(3, "História do Mar");
            Genre g4 = new Genre(4, "Ficção Científica");
            Genre g5 = new Genre(5, "Fantasia");
            Genre g6 = new Genre(6, "Ficção Histórica");
            Genre g7 = new Genre(7, "Biografia");
            Genre g8 = new Genre(8, "Terror");
            Genre g9 = new Genre(9, "Mistério");
            Genre g10 = new Genre(10, "Literatura Brasileira");
            Genre g11 = new Genre(11, "Distopia");
            Genre g12 = new Genre(12, "Ficção Política");
            Genre g13 = new Genre(13, "Literatura Britânica");
            Genre g14 = new Genre(14, "Romance Policial");
            Genre g15 = new Genre(15, "Realismo Moderno");
            Genre g16 = new Genre(16, "Horror Gótico");
            Genre g17 = new Genre(17, "Literatura Russa");
            Genre g18 = new Genre(18, "Literatura Alemã");
            Genre g19 = new Genre(19, "Literatura Latino-Americana");
            Genre g20 = new Genre(20, "Poema Épico");
            Genre g21 = new Genre(21, "Tragédia");

            // Livros
            Book b1 = new Book(1, "Moby Dick", 89.90, "Herman Melville", 1851);
            b1.Genres.Add(g1);
            b1.Genres.Add(g2);
            b1.Genres.Add(g3);

            Book b2 = new Book(2, "1984", 74.50, "George Orwell", 1949);
            b2.Genres.Add(g11);
            b2.Genres.Add(g12);
            b2.Genres.Add(g13);

            Book b3 = new Book(3, "Senhor dos Anéis: A Sociedade do Anel", 120.00, "J.R.R. Tolkien", 1954);
            b3.Genres.Add(g5);
            b3.Genres.Add(g2);

            Book b4 = new Book(4, "O Código Da Vinci", 67.90, "Dan Brown", 2003);
            b4.Genres.Add(g9);
            b4.Genres.Add(g14);

            Book b5 = new Book(5, "Dom Quixote", 92.70, "Miguel de Cervantes", 1605);
            b5.Genres.Add(g2);

            Book b6 = new Book(6, "A Guerra dos Tronos", 95.80, "George R.R. Martin", 1996);
            b6.Genres.Add(g5);

            Book b7 = new Book(7, "O Egípcio", 58.70, "Mika Waltari", 1945);
            b7.Genres.Add(g6);

            Book b8 = new Book(8, "O Conde de Monte Cristo", 79.90, "Alexandre Dumas", 1844);
            b8.Genres.Add(g6);
            b8.Genres.Add(g2);

            Book b9 = new Book(9, "Memórias Póstumas de Brás Cubas", 49.90, "Machado de Assis", 1881);
            b9.Genres.Add(g10);
            b9.Genres.Add(g15);

            Book b10 = new Book(10, "Frankenstein", 54.90, "Mary Shelley", 1818);
            b10.Genres.Add(g8);
            b10.Genres.Add(g4);
            b10.Genres.Add(g16);


            Book b11 = new Book(11, "Drácula", 69.99, "Bram Stoker", 1897);
            b11.Genres.Add(g8);
            b11.Genres.Add(g9);
            b11.Genres.Add(g16);

            Book b12 = new Book(12, "O Hobbit", 78.99, "J.R.R. Tolkien", 1937);
            b12.Genres.Add(g5);
            b12.Genres.Add(g2);

            Book b13 = new Book(13, "A Revolução dos Bichos", 40.00, "George Orwell", 1945);
            b13.Genres.Add(g13);
            b13.Genres.Add(g12);

            Book b14 = new Book(14, "Crime e Castigo", 90.00, "Fiódor Dostoiévski", 1866);
            b14.Genres.Add(g9);
            b14.Genres.Add(g17);

            Book b15 = new Book(15, "O Senhor das Moscas", 60.00, "William Golding", 1954);
            b15.Genres.Add(g13);

            Book b16 = new Book(16, "O Nome da Rosa", 68.00, "Umberto Eco", 1980);
            b16.Genres.Add(g9);
            b16.Genres.Add(g6);
            b16.Genres.Add(g14);

            Book b17 = new Book(17, "A Metamorfose", 34.00, "Franz Kafka", 1915);
            b17.Genres.Add(g18);

            Book b18 = new Book(18, "Cem Anos de Solidão", 89.90, "Gabriel García Márquez", 1967);
            b18.Genres.Add(g19);

            Book b19 = new Book(19, "O Silmarillion", 80.00, "J.R.R. Tolkien", 1977);
            b19.Genres.Add(g5);

            Book b20 = new Book(20, "A Ilha do Tesouro", 56.00, "Robert Louis Stevenson", 1883);
            b20.Genres.Add(g2);
            b20.Genres.Add(g3);
            b20.Genres.Add(g13);

            Book b21 = new Book(21, "Guerra e Paz", 110.00, "Liev Tolstói", 1869);
            b21.Genres.Add(g6);

            Book b22 = new Book(22, "1984", 75.00, "George Orwell", 1949);
            b22.Genres.Add(g11);
            b22.Genres.Add(g12);
            b22.Genres.Add(g13);

            Book b23 = new Book(23, "A Divina Comédia", 130.00, "Dante Alighieri", 1320);
            b23.Genres.Add(g6);
            b23.Genres.Add(g20);

            Book b24 = new Book(24, "Macbeth", 49.90, "William Shakespeare", 1606);
            b24.Genres.Add(g13);
            b24.Genres.Add(g21);

            Book b25 = new Book(25, "As Aventuras de Sherlock Holmes", 60.00, "Arthur Conan Doyle", 1892);
            b25.Genres.Add(g9);
            b25.Genres.Add(g14);
            b25.Genres.Add(g13);

            await _context.Genres.AddRangeAsync(
            g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21
            );

            // Adicionando Livros
            await _context.Books.AddRangeAsync(
                b1, b2, b3, b4, b5, b6, b7, b8, b9, b10,
                b11, b12, b13, b14, b15, b16, b17, b18, b19, b20,
                b21, b22, b23, b24, b25
            );

            await _context.SaveChangesAsync();

        }
    }
}
