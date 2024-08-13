using CodeFirstApplication.Data;
using CodeFirstApplication.Models;

namespace CodeFirstApplication.Services
{
    public class MovieService:IMovieService
    {
        private readonly MovieDbContext _db;
        private readonly IConfiguration _configuration;
        public MovieService(MovieDbContext db, IConfiguration configuration)
        { 
            _db = db;
            _configuration = configuration;
        }
        public  List<Movie> GetMovies() 
        {
            var movies = _db.Movies.ToList();
            return movies;
        }
        public Movie GetMovieById(int id) 
        { 
            var movie = _db.Movies.FirstOrDefault(m => m.Id == id);
            return movie; 
        }
        public List<Movie> GetMoviesByLeatest() 
        {
            var movies = _db.Movies.OrderByDescending(m=>m.ReleaseYear).ToList();
            return movies;
        }
        public List<Movie> GetMoviesByOldest() 
        {
            var movies = _db.Movies.OrderBy(m => m.ReleaseYear).ToList();
            return movies;
        }
        public void AddMovie(Movie movie) 
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
        }
    }
}
