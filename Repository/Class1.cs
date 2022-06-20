using Neo4j.Driver;

namespace Repository;

public class Class1: IClass1, IDisposable
{
    public async void Testing()
    {
        IDriver driver = GraphDatabase.Driver("neo4j+s://43e593b0.databases.neo4j.io", AuthTokens.Basic("neo4j", "uGK9Wa-RANP3aaYXGy-tET0qhqq8uoK7Egwx5FhxeCI"));
        IAsyncSession session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
        try
        {
            IResultCursor cursor = await session.RunAsync("CREATE (n) RETURN n");
            await cursor.ConsumeAsync();
        }
        finally
        {
            await session.CloseAsync();
        }
        await driver.CloseAsync();
    }

    public void Dispose()
    {
        
    }
}

