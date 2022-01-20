using MyBlazorApp.CoreBusiness.Models;

namespace MyBlazorApp.UseCases.SearchMovieScreen
{
    public interface IViewMovie
    {
        Movie Execute(int id);
    }
}