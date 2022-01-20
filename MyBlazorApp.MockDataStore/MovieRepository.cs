using MyBlazorApp.CoreBusiness.Models;
using MyBlazorApp.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlazorApp.MockDataStore
{
    public class MovieRepository : IMovieRepository
    {
        private List<Movie> movies;
        public MovieRepository()
        {
            movies = new List<Movie>
            {
                new Movie { Id = 1, Title="Iron Man", YearReleased = "2008", ImageLink="https://m.media-amazon.com/images/I/517EnJmL7+L._AC_UY218_.jpg", Description="After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil."},
                new Movie { Id = 2, Title="Hercules", YearReleased = "2012", ImageLink="https://m.media-amazon.com/images/I/915zrle1jhL._AC_UY218_.jpg", Description="Having endured his legendary twelve labors, Hercules, the Greek demigod, has his life as a sword-for-hire tested when the King of Thrace and his daughter seek his aid in defeating a tyrannical warlord."},
                new Movie { Id = 3, Title="2012", YearReleased = "2009", ImageLink="https://m.media-amazon.com/images/I/91gj8w+frzL._AC_UY218_.jpg", Description="A frustrated writer struggles to keep his family alive when a series of global catastrophes threatens to annihilate mankind."}

            };
        }
        public Movie GetMovie(int id)
        {
           return movies.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Movie> GetMovies(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return movies;
            return movies.Where(x => x.Title.ToLower().Contains(filter.ToLower()));
        }
    }
}
