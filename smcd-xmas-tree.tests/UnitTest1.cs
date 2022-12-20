namespace smcd_xmas_tree.tests;

public class UnitTest1
{
    [Fact]
    public void treeOfheightOne()
    {
        Assert.Equal("*",TreeGenerator.generate(1));
    }
}

public class TreeGenerator
{
    public static IEnumerable<char> generate(int i)
    {
        return "*";
    }
}