using System.Reflection;
using System.Text.Json;
using Neo4j.Driver;

namespace Repository.Repositories.Shop;

using Models;

public class ShopCreationRepository: Repository, IShopCreationRepository
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