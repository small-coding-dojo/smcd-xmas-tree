namespace smcd_xmas_tree.tests;

public class TreeGeneratorTests
{
    [Fact]
    public void TreeOfHeightOne()
    {
        Assert.Equal("*",TreeGenerator.generate(1));
    }

    [Fact]
    public void TreeOfHeightTwo()
    {
        Assert.Equal(" * \n***",TreeGenerator.generate(2));
    }

    [Fact]
    public void TreeOfHeightThree()
    {
        Assert.Equal("  *  \n *** \n*****",TreeGenerator.generate(3));
    }
}

public class TreeGenerator
{
    public static string generate(int i)
    {
        if (i == 1)
        {
            return "*";
        }
        else
        {
            return " " + generate(i - 1).Replace("\n", " \n ")+" \n" + new string('*', (2*i)-1);
        }
    }
}