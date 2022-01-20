using MyBlazorApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlazorApp.UseCases.PluginInterfaces.DataStore
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies(string filter = null);
        Movie GetMovie(int id);
    }
}
