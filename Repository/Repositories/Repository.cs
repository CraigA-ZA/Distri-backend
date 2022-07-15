using Neo4j.Driver;

namespace Repository.Repositories;

public class Repository
{
    protected readonly IDriver Driver;
    protected readonly IAsyncSession Session; 
    
    protected Repository()
    {
        Driver = GraphDatabase.Driver("neo4j+s://43e593b0.databases.neo4j.io", AuthTokens.Basic("neo4j", "uGK9Wa-RANP3aaYXGy-tET0qhqq8uoK7Egwx5FhxeCI"));
        Session = Driver.AsyncSession(o => o.WithDatabase("neo4j"));
    }
    public async void Testing()
    {
        
        try
        {
            IResultCursor cursor = await Session.RunAsync("CREATE (n) RETURN n");
            await cursor.ConsumeAsync();
        }
        finally
        {
            await Session.CloseAsync();
        }
        await Driver.CloseAsync();
    }

}