using BusinessLogic.DTOs.DTOs;
using Repository.Models;

namespace BusinessLogic.Mapping;

public class ShopMapper: IShopMapper
{
    public Shop ToShop(ShopDTO shopDto)
    {
        return new Shop()
        {
            ShopName = shopDto.ShopName,
            ShopDescription = shopDto.ShopDescription,
            Location = shopDto.Location,
            Instagram = shopDto.Instagram,
            Facebook = shopDto.Facebook
        };
    }

    public ShopDTO ToShopDto(Shop shop)
    {
        return new ShopDTO()
        {
            ShopName = shop.ShopName,
            ShopDescription = shop.ShopDescription,
            Location = shop.Location,
            Instagram = shop.Instagram,
            Facebook = shop.Facebook
        };
    }
}