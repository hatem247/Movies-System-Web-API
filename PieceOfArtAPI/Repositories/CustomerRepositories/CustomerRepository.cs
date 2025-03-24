using Microsoft.EntityFrameworkCore;
using PieceOfArtAPI.Data;
using PieceOfArtAPI.DTOs;
using PieceOfArtAPI.Models;

namespace PieceOfArtAPI.Repositories.CustomerRepositories
{
    public class CustomerRepository : ICustomerRepository
    {
        protected readonly AppDbContext context;
        public CustomerRepository(AppDbContext _context) { context = _context; }
        public void Add(CustomerAddDto customer)
        {
            Customer newCustomer = new Customer
            {
                Name = customer.Name,
                Email = customer.Email,
                ArtPieces = context.ArtPieces.Where(p => customer.ArtPiecesIds.Contains(p.Id)).ToList()
            };
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public List<CustomerGetDto> GetAll()
        {
            return context.Customers.Include(x => x.LoyaltyCard).Select(c => new CustomerGetDto
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                ArtPieces = c.ArtPieces.Select(p => new ArtPieceForCustomerDto
                {
                    Id = p.Id,
                    Title = p.Title,
                    Description = p.Description,
                    Price = p.Price,
                    Category = new CategoryForArtPieceDto
                    {
                        Id = p.Category.Id,
                        Name = p.Category.Name
                    }
                }).ToList(),
                LoyaltyCard = new LoyaltyCardForCustomerDto
                {
                    Id = c.LoyaltyCard.Id,
                    Balance = c.LoyaltyCard.Balance
                }
            }).ToList();
        }

        public void Update(CustomerUpdateDto customer, int Id)
        {
            var customerToUpdate = context.Customers.Include(c => c.ArtPieces).Include(c => c.LoyaltyCard).FirstOrDefault(c => c.Id == Id);
            if (customerToUpdate == null) throw new Exception("Customer Not Found");
            else
            {
                customerToUpdate.Name = customer.Name;
                customerToUpdate.Email = customer.Email;
                customerToUpdate.ArtPieces = context.ArtPieces.Where(p => customer.ArtPiecesIds.Contains(p.Id)).ToList();
                context.Customers.Update(customerToUpdate);
                context.SaveChanges();
            }
        }
    }
}
