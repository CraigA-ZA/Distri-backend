using Repository;
using Repository.Repositories.TestQuery;

namespace Repository.Models.Services;

public class test: Itest
{
    private readonly ITestQuery _testQuery;
    public test(ITestQuery testQuery)
    {
        _testQuery = testQuery;

    }
    public string testing()
    {
        _testQuery.Testing();
        return "testingggggggggggggggggggggggggt";
    }
}