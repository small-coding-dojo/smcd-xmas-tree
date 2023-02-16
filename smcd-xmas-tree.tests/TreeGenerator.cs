using System.Data;
using System.Text;

namespace smcd_xmas_tree.tests;

public static class TreeGenerator
{ 
    public static string Generate(int treeHeight)
    {
        if (treeHeight == 0)
        {
            return "";
        }
        
        var subTree = GenerateLevels(treeHeight);
        CenterLevels(subTree);
        return subTree.AsPrintable();
    }

    public static List<string> GenerateLevels(int treeHeight)
    {
        if (treeHeight == 1)
        {
            return new List<string>{"*"};
        }

        var result = GenerateLevels(treeHeight - 1);
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

    public static List<string> CenterLevels(List<string> treeList)
    {
        var currentPadding = " ";
        
        for (var rowIndex = treeList.Count - 2; rowIndex >= 0; rowIndex--)
        {
            treeList[rowIndex] = currentPadding + treeList[rowIndex] + currentPadding;
            currentPadding += " ";
        }

        return treeList;
    }

    public static string AsPrintable(this List<string> treeList)
    {
        return string.Join("\n", treeList);
    }
}