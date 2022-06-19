using Repository;

namespace BusinessLogic.Services;

public class test: Itest
{
    private readonly IClass1 _class1;
    public test(IClass1 class1)
    {
        _class1 = class1;

    }
    public string testing()
    {
        _class1.Testing();
        return "testingggggggggggggggggggggggggt";
    }
}