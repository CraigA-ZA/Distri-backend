using BusinessLogic.DTOs.DTOs;
using Repository.Models;

namespace BusinessLogic.Mapping;

public interface IShopMapper
{
    Shop ToShop(ShopDTO shopDto);
    ShopDTO ToShopDto(Shop shop);
}