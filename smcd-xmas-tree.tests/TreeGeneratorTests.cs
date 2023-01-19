namespace smcd_xmas_tree.tests;

public class TreeGeneratorTests
{
    [Fact]
    public void TreeOfHeightOne()
    {
        Assert.Equal("*", TreeGenerator.generate(1));
    }

    [Fact]
    public void TreeOfHeightTwo()
    {
        Assert.Equal(" * \n***", TreeGenerator.generate(2));
    }

    [Fact]
    public void TreeOfHeightThree()
    {
        Assert.Equal("  *  \n *** \n*****", TreeGenerator.generate(3));
    }
  
    [Fact]
    public void TreeOfHeightZero()
    {
        Assert.Equal("",TreeGenerator.generate(0));
    }

}

public class TreeGenerator
{ 
    public static string generate(int treeHeight)
    {
        return treeHeight switch { 
            0 => "", 
            1 => "*",
            _ => PadBothSides(generate(treeHeight - 1)) + "\n" + CreateLastTreeLine(treeHeight)
        };
    }

    private static string PadBothSides(string smallerTree)
    {
        return " " + smallerTree.Replace("\n", " \n ") + " ";
    }

    private static string CreateLastTreeLine(int treeHeight)
    {
        return new string('*', WidthFor(treeHeight));
    }

    private static int WidthFor(int height)
    {
        return (2 * height) - 1;
    }
}
