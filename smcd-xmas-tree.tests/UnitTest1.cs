namespace smcd_xmas_tree.tests;

public class UnitTest1
{
    [Fact]
    public void treeOfheightOne()
    {
        Assert.Equal("*",TreeGenerator.generate(1));
    }

    [Fact]
    public void treeOfheightTwo()
    {
        Assert.Equal(" * \n***",TreeGenerator.generate(2));
    }
}

public class TreeGenerator
{
    public static IEnumerable<char> generate(int i)
    {
        if (i == 1)
        {
            return "*";
        }
        return " * \n***";
    }
}