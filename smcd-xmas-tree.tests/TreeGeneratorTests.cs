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
}

public class TreeGenerator
{ 
    public static string generate(int treeHeight)
    {
        return treeHeight switch { 
            0 => "", 
            1 => tempGenerator(treeHeight),
            _ => PadBothSides(generate(treeHeight - 1)) + "\n" + CreateLastTreeLine(treeHeight)
        };
    }

    public static string tempGenerator ( int treeHeight ) {
        return string.Join ( "\n", GenerateRecursively(treeHeight));
    }
    
    public static List<string> GenerateRecursively(int treeHeight)
    {
        if (treeHeight == 1)
        {
            return new List<string>{"*"};
        }

        var result = GenerateRecursively(treeHeight - 1);
        result.Add(new string('*', 1+(treeHeight-1)*2));
        return result;
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

    public static List<string> PadList(List<string> treeList)
    {
        var currentPadding = " ";
        
        for (var rowIndex = treeList.Count - 2; rowIndex >= 0; rowIndex--)
        {
            treeList[rowIndex] = currentPadding + treeList[rowIndex] + currentPadding;
            currentPadding += " ";
        }

        return treeList;
    }
}
