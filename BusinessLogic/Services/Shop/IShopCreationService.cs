using BusinessLogic.DTOs.DTOs;

namespace Repository.Models.Services.Shop;

public interface IShopCreationService
{
    void CreateShop(ShopDTO shop);
}