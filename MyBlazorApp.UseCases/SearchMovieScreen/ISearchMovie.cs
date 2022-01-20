using MyBlazorApp.CoreBusiness.Models;
using System.Collections.Generic;

namespace MyBlazorApp.UseCases.SearchMovieScreen
{
    public interface ISearchMovie
    {
        IEnumerable<Movie> Execute(string filter = null);
    }
}