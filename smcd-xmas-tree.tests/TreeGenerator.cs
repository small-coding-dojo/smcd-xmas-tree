using System.Data;
using System.Text;

namespace smcd_xmas_tree.tests;

public class TreeGenerator
{ 
    public static string generate(int treeHeight)
    {
        return treeHeight switch { 
            0 => "", 
            _ => tempGenerator(treeHeight)

        };
    }

    public static string tempGenerator ( int treeHeight )
    {
        var subTree = GenerateRecursively(treeHeight);
        PadList(subTree);
        return ConcatenateList(subTree);
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

    public static string ConcatenateList(List<string> treeList) => string.Join("\n", treeList);
}