using Neo4j.Driver;

namespace Repository.Repositories.Shop;
using Domain.Models;

public class ShopCreationRepository: Domain.Repositories.Repository, IShopCreationRepository
{
    public async void CreateShop(Shop shop)
    {
        try
        {
            IResultCursor cursor = await Session.RunAsync($"CREATE (s:shop $shop) RETURN s", new {shop});
            await cursor.ConsumeAsync();

        }
        finally
        {
            await Session.CloseAsync();
        }
        await Driver.CloseAsync();
    }
}