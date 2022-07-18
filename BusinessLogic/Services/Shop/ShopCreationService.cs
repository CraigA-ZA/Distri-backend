using Repository.Repositories.Shop;

namespace BusinessLogic.Services.Shop;

public class ShopCreationService: IShopCreationService
{
    private readonly IShopCreationRepository _shopCreationRepository;
    
    public ShopCreationService(IShopCreationRepository shopCreationRepository)
    {
        _shopCreationRepository = shopCreationRepository;
    }
    public async void CreateShop(Domain.Models.Shop shop)
    {
         _shopCreationRepository.CreateShop(shop);
    }
    
}