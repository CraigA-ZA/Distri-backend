namespace Repository.Repositories.Shop;
using Domain.Models;

public interface IShopCreationRepository
{
    void CreateShop(Shop shop);
}