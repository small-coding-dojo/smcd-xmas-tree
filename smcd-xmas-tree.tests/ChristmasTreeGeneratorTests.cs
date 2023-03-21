namespace smcd_xmas_tree.tests;

public class ChristmasTreeGeneratorTests
{
    [Fact]
    public void TreeOfHeightOne()
    {
        Assert.Equal("*", ChristmasTreeGenerator.ChristmasTree(1));
    }

    [Fact]
    public void TreeOfHeightTwo()
    {
        Assert.Equal(" * \n***", ChristmasTreeGenerator.ChristmasTree(2));
    }

    [Fact]
    public void TreeOfHeightThree()
    {
        Assert.Equal("  *  \n *** \n*****", ChristmasTreeGenerator.ChristmasTree(3));
    }
  
    [Fact]
    public void TreeOfHeightZero()
    {
        Assert.Equal("",ChristmasTreeGenerator.ChristmasTree(0));
    }

    [Fact]
    public void StringArrayTreeHeight1()
    {
        Assert.Equal(new List<string> {"*"},ChristmasTreeGenerator.GenerateLevels(1));
    }

    [Fact]
    public void StringArrayTreeHeight2()
    {
        Assert.Equal(new List<string> {"*", "***"},ChristmasTreeGenerator.GenerateLevels(2));
    }

    [Fact]
    public void StringArrayTreeHeight4()
    {
        Assert.Equal(new List<string> {"*", "***","*****","*******"},ChristmasTreeGenerator.GenerateLevels(4));
    }

    [Fact]
    public void CorrectlyPadAListForTreeHeight2()
    {
        var treeList = new List<string> {"*", "***"};
        Assert.Equal(new List<string>{" * ", "***"},ChristmasTreeGenerator.CenterLevels(treeList));
    }

    [Fact]
    public void CorrectlyPadAListForTreeHeight3()
    {
        var treeList = new List<string> {"*", "***", "*****"};
        Assert.Equal(new List<string>{"  *  ", " *** ", "*****"},ChristmasTreeGenerator.CenterLevels(treeList));
    }

    [Fact]
    public void CorrectlyPadAListForTreeHeight1()
    {
        var treeList = new List<string> { "*" };
        Assert.Equal(new List<string>{ "*" },ChristmasTreeGenerator.CenterLevels(treeList));
    }

    [Fact]
    public void PaddingDoesntDieOnEmptyInput()
    {
        var treeList = new List<string> {};
        Assert.Equal(new List<string>{},ChristmasTreeGenerator.CenterLevels(treeList));
    }
    
    [Fact]
    public void ConcatenateListWithTwoRows()
    {
        var treeList = new List<string> { " * ", "***"};
        Assert.Equal(" * \n***",ChristmasTreeGenerator.AsPrintable(treeList));
    }
    [Fact]
    public void ConcatenateListWithFourRows()
    {
        var treeList = new List<string> { "    *    ", "  ***  ", " ***** ", "*******"};
        Assert.Equal("    *    \n  ***  \n ***** \n*******",ChristmasTreeGenerator.AsPrintable(treeList));
    }

    [Fact]
    public void ConcatenateEmptyListDoesntDie()
    {
        var treeList = new List<string> { };
        Assert.Equal("",ChristmasTreeGenerator.AsPrintable(treeList));
    }

    [Fact]
    public void ConcatenateSingleItems()
    {
        var treeList = new List<string> { "*" };
        Assert.Equal("*",ChristmasTreeGenerator.AsPrintable(treeList));
    }

}