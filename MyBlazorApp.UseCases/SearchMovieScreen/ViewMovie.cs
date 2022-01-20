using MyBlazorApp.CoreBusiness.Models;
using MyBlazorApp.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlazorApp.UseCases.SearchMovieScreen
{
    public class ViewMovie : IViewMovie
    {
        private readonly IMovieRepository _movieRepository;

        public ViewMovie(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public Movie Execute(int id)
        {
            return _movieRepository.GetMovie(id);
        }
    }
}
