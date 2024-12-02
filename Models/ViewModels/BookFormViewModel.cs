using Bookstore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.ViewModels
{
    public class BookFormViewModel
    {
        public Book Book { get; set; }
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();

        [Display(Name = "Gêneros Literários")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public List<int> SelectedGenresIds { get; set; } = new List<int>();

        public List<SelectListItem> GenresSelect => GenerateGenresSelect();

        public List<Genre> Genre { get; internal set; }

        private List<SelectListItem> GenerateGenresSelect()
        {
            List<SelectListItem> genresSelect = new List<SelectListItem>();
            if (Genres is not null)
            {
                foreach (Genre genre in Genres)
                {
                    genresSelect.Add(new SelectListItem { Value = genre.Id.ToString(), Text = genre.Name });
                }
            }
            return genresSelect;
        }
    }
}