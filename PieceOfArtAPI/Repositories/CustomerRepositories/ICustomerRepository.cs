using PieceOfArtAPI.DTOs;

namespace PieceOfArtAPI.Repositories.CustomerRepositories
{
    public interface ICustomerRepository
    {
        List<CustomerGetDto> GetAll();
        void Add(CustomerAddDto customer);
        void Update(CustomerUpdateDto customer, int Id);
    }
}
