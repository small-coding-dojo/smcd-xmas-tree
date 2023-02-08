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

    [Fact]
    public void StringArrayTreeHeight1()
    {
        Assert.Equal(new List<string> {"*"},TreeGenerator.GenerateRecursively(1));
    }

    [Fact]
    public void StringArrayTreeHeight2()
    {
        Assert.Equal(new List<string> {"*", "***"},TreeGenerator.GenerateRecursively(2));
    }

    [Fact]
    public void StringArrayTreeHeight4()
    {
        Assert.Equal(new List<string> {"*", "***","*****","*******"},TreeGenerator.GenerateRecursively(4));
    }

    [Fact]
    public void CorrectlyPadAListForTreeHeight2()
    {
        var treeList = new List<string> {"*", "***"};
        Assert.Equal(new List<string>{" * ", "***"},TreeGenerator.PadList(treeList));
    }

    [Fact]
    public void CorrectlyPadAListForTreeHeight3()
    {
        var treeList = new List<string> {"*", "***", "*****"};
        Assert.Equal(new List<string>{"  *  ", " *** ", "*****"},TreeGenerator.PadList(treeList));
    }

    [Fact]
    public void CorrectlyPadAListForTreeHeight1()
    {
        var treeList = new List<string> { "*" };
        Assert.Equal(new List<string>{ "*" },TreeGenerator.PadList(treeList));
    }

    [Fact]
    public void PaddingDoesntDieOnEmptyInput()
    {
        var treeList = new List<string> {};
        Assert.Equal(new List<string>{},TreeGenerator.PadList(treeList));
    }
    
    [Fact]
    public void ConcatenateListWithTwoRows()
    {
        var treeList = new List<string> { " * ", "***"};
        Assert.Equal(" * \n***",TreeGenerator.ConcatenateList(treeList));
    }
    [Fact]
    public void ConcatenateListWithFourRows()
    {
        var treeList = new List<string> { "    *    ", "  ***  ", " ***** ", "*******"};
        Assert.Equal("    *    \n  ***  \n ***** \n*******",TreeGenerator.ConcatenateList(treeList));
    }

    [Fact]
    public void ConcatenateEmptyListDoesntDie()
    {
        var treeList = new List<string> { };
        Assert.Equal("",TreeGenerator.ConcatenateList(treeList));
    }

    [Fact]
    public void ConcatenateSingleItems()
    {
        var treeList = new List<string> { "*" };
        Assert.Equal("*",TreeGenerator.ConcatenateList(treeList));
    }

}