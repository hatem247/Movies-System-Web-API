using PieceOfArtAPI.Data;
using PieceOfArtAPI.DTOs;
using PieceOfArtAPI.Models;

namespace PieceOfArtAPI.Repositories.LoyaltyCardRepositories
{
    public class LoyaltyCardRepository : ILoyaltyCardRepository
    {
        protected readonly AppDbContext context;
        public LoyaltyCardRepository(AppDbContext _context) { context = _context; }
        public void Add(LoyaltyCardAddDto loyaltyCard)
        {
            var customer = context.Customers.Find(loyaltyCard.CustomerId);
            if (customer == null) throw new Exception("Customer not Found");
            if(customer.LoyaltyCard != null) throw new Exception("Customer already has a Loyalty Card");
            LoyaltyCard loyalty = new LoyaltyCard
            {
                Balance = loyaltyCard.Balance,
                Customer = context.Customers.Find(loyaltyCard.CustomerId),
                CustomerId = loyaltyCard.CustomerId
            };
            context.LoyaltyCards.Add(loyalty);
            context.SaveChanges();

            customer.LoyaltyCard = loyalty;
            context.Customers.Update(customer);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            LoyaltyCard loyaltyCard = context.LoyaltyCards.Find(Id);
            if(loyaltyCard == null) throw new Exception("Loyalty Card not Found");
            else
            {
                var customer = context.Customers.Find(loyaltyCard.CustomerId);
                customer.LoyaltyCard = null;
                context.Customers.Update(customer);
                context.SaveChanges();

                context.LoyaltyCards.Remove(loyaltyCard);
                context.SaveChanges();
            }
        }
    }
}
