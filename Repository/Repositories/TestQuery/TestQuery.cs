using Neo4j.Driver;

namespace Domain.Repositories.TestQuery;

public class TestQuery: Repository, ITestQuery
{
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