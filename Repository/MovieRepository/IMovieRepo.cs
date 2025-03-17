using Movies_System_Web_API.DTOs;

namespace Movies_System_Web_API.Repository.MovieRepository
{
    public interface IMovieRepo
    {
        public void Add(CinemaAll addAll);
        public List<CinemaAll> GetAll();
        public CinemaAll GetById(int id);
    }
}
