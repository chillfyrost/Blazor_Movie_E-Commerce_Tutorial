using MyBlazorApp.CoreBusiness.Models;
using MyBlazorApp.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlazorApp.UseCases.SearchMovieScreen
{
    public class SearchMovie : ISearchMovie
    {
        private readonly IMovieRepository _movieRepository;

        public SearchMovie(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IEnumerable<Movie> Execute(string filter = null)
        {
            return _movieRepository.GetMovies(filter);
        }
    }
}
