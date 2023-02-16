namespace smcd_xmas_tree.tests;

public class TreeGeneratorTests
{
    [Fact]
    public void TreeOfHeightOne()
    {
        Assert.Equal("*", TreeGenerator.Generate(1));
    }

    [Fact]
    public void TreeOfHeightTwo()
    {
        Assert.Equal(" * \n***", TreeGenerator.Generate(2));
    }

    [Fact]
    public void TreeOfHeightThree()
    {
        Assert.Equal("  *  \n *** \n*****", TreeGenerator.Generate(3));
    }
  
    [Fact]
    public void TreeOfHeightZero()
    {
        Assert.Equal("",TreeGenerator.Generate(0));
    }

    [Fact]
    public void StringArrayTreeHeight1()
    {
        Assert.Equal(new List<string> {"*"},TreeGenerator.GenerateLevels(1));
    }

    [Fact]
    public void StringArrayTreeHeight2()
    {
        Assert.Equal(new List<string> {"*", "***"},TreeGenerator.GenerateLevels(2));
    }

    [Fact]
    public void StringArrayTreeHeight4()
    {
        Assert.Equal(new List<string> {"*", "***","*****","*******"},TreeGenerator.GenerateLevels(4));
    }

    [Fact]
    public void CorrectlyPadAListForTreeHeight2()
    {
        var treeList = new List<string> {"*", "***"};
        Assert.Equal(new List<string>{" * ", "***"},TreeGenerator.CenterLevels(treeList));
    }

    [Fact]
    public void CorrectlyPadAListForTreeHeight3()
    {
        var treeList = new List<string> {"*", "***", "*****"};
        Assert.Equal(new List<string>{"  *  ", " *** ", "*****"},TreeGenerator.CenterLevels(treeList));
    }

    [Fact]
    public void CorrectlyPadAListForTreeHeight1()
    {
        var treeList = new List<string> { "*" };
        Assert.Equal(new List<string>{ "*" },TreeGenerator.CenterLevels(treeList));
    }

    [Fact]
    public void PaddingDoesntDieOnEmptyInput()
    {
        var treeList = new List<string> {};
        Assert.Equal(new List<string>{},TreeGenerator.CenterLevels(treeList));
    }
    
    [Fact]
    public void ConcatenateListWithTwoRows()
    {
        var treeList = new List<string> { " * ", "***"};
        Assert.Equal(" * \n***",TreeGenerator.AsPrintable(treeList));
    }
    [Fact]
    public void ConcatenateListWithFourRows()
    {
        var treeList = new List<string> { "    *    ", "  ***  ", " ***** ", "*******"};
        Assert.Equal("    *    \n  ***  \n ***** \n*******",TreeGenerator.AsPrintable(treeList));
    }

    [Fact]
    public void ConcatenateEmptyListDoesntDie()
    {
        var treeList = new List<string> { };
        Assert.Equal("",TreeGenerator.AsPrintable(treeList));
    }

    [Fact]
    public void ConcatenateSingleItems()
    {
        var treeList = new List<string> { "*" };
        Assert.Equal("*",TreeGenerator.AsPrintable(treeList));
    }

}