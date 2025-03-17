using Microsoft.EntityFrameworkCore;
using Movies_System_Web_API.DTOs;
using Movies_System_Web_API.Models;

namespace Movies_System_Web_API.Repository.MovieRepository
{
    public class MovieRepo: IMovieRepo
    {
        private readonly AppDbContext _context;

        public MovieRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Add(CinemaAll addAll)
        {
            Movie movie = new Movie
            {
                Title = addAll.Title,
                ReleaseYear = addAll.ReleaseYear,
                Category = new Category
                {
                    Name = addAll.categoryDto.Name
                },
                Cinema = new Cinema
                {
                    Name = addAll.cinemaDto.Name,
                    Placeholder = addAll.cinemaDto.Placeholder,
                }
            };
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
        public List<CinemaAll> GetAll()
        {
            var res = _context.Movies
 
                .Include(x => x.Category)
                .Include(x => x.Cinema).Select(x => new CinemaAll
                {
                    Title = x.Title,
                    ReleaseYear = x.ReleaseYear,
                    categoryDto = new CategoryDto
                    {
                        Name = x.Category.Name,
                    },
                    cinemaDto = new CinemaDto
                    {
                        Name = x.Cinema.Name,
                        Placeholder = x.Cinema.Placeholder,
                    }
                }).ToList();
        }
        public CinemaAll GetById(int id)
        {
            var res = _context.Movies
                .Include(x => x.Category)
                .Include(x => x.Cinema)
                .FirstOrDefault(x => x.Id == id);
            if (res != null)
            {
                return new CinemaAll
                {
                    Title = res.Title,
                    ReleaseYear = res.ReleaseYear,
                    categoryDto = new CategoryDto
                    {
                        Name = res.Category.Name,
                    },
                    cinemaDto = new CinemaDto
                    {
                        Name = res.Cinema.Name,
                        Placeholder = res.Cinema.Placeholder,
                    }
                };
            }
            else
            {
                throw new Exception("Not Found");
            }
        }
    }
}
