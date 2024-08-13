using CodeFirstApplication.Models;

namespace CodeFirstApplication.Services
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
        Movie GetMovieById(int id);
        List<Movie> GetMoviesByLeatest();
        List<Movie> GetMoviesByOldest();
        void AddMovie(Movie movie);
        
    }
}
