using BusinessLogic.DTOs.DTOs;
using BusinessLogic.Mapping;
using Repository.Repositories.Shop;

namespace Repository.Models.Services.Shop;
using Models;
public class ShopCreationService: IShopCreationService
{
    private readonly IShopCreationRepository _shopCreationRepository;
    private readonly IShopMapper _shopMapper;
    
    public ShopCreationService(IShopCreationRepository shopCreationRepository, IShopMapper shopMapper)
    {
        _shopCreationRepository = shopCreationRepository;
        _shopMapper = shopMapper;
    }
    public async void CreateShop(ShopDTO shop)
    {
         _shopCreationRepository.CreateShop(_shopMapper.ToShop(shop));
    }
    
}