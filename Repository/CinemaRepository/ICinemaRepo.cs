using Movies_System_Web_API.DTOs;

namespace Movies_System_Web_API.Repository.CinemaRepository
{
    public interface ICinemaRepo
    {
        public void Add(AddAllCinema addAllCinema);
        public List<AddAllCinema> GetAll();
        public void Update(AddAllCinema updateAllCinema, int id);


    }
}
