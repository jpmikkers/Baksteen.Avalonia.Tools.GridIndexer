using Avalonia.Controls;
using Avalonia.LogicalTree;
using static Baksteen.Avalonia.Tools.GridIndexer.GI;

namespace Baksteen.Avalonia.Tools.GridIndexer;

public static class GridIndexer
{
    public static void RunGridIndexer(ILogical parent)
    {
        foreach(var grid in parent.GetLogicalDescendants().OfType<Grid>())
        {
            UpdateGridIndex(grid, IndexTarget.Row);
        }

        foreach(var grid in parent.GetLogicalDescendants().OfType<Grid>())
        {
            UpdateGridIndex(grid, IndexTarget.Column);
        }
    }

    private static void UpdateGridIndex(Grid grid, IndexTarget indexTarget)
    {
        int index = 0;

        foreach(var element in grid.GetLogicalChildren().OfType<Control>())
        {
            if(GI.GetTypeAndValue(element, indexTarget) is (GI.ValueType ValueType, int Value))
            {
                index = ValueType switch
                {
                    GI.ValueType.Absolute => Value,
                    GI.ValueType.Relative => Math.Max(0, index + Value),
                    _ => throw new GridIndexerException($"{ValueType} is not implemented.")
                };
            }

            if(indexTarget == IndexTarget.Row)
            {
                if(element.IsSet(Grid.RowProperty))
                {
                    ExpandDefinitions(grid, indexTarget, element.GetValue(Grid.RowProperty));
                }
                else
                {
                    ExpandDefinitions(grid, indexTarget, index);
                    Grid.SetRow(element, index);
                }
            }
            else
            {
                if(element.IsSet(Grid.ColumnProperty))
                {
                    ExpandDefinitions(grid, indexTarget, element.GetValue(Grid.ColumnProperty));
                }
                else
                {
                    ExpandDefinitions(grid, indexTarget, index);
                    Grid.SetColumn(element, index);
                }
            }
        }
    }

    private static void ExpandDefinitions(Grid grid, IndexTarget indexTarget, int index)
    {
        if(indexTarget == IndexTarget.Row)
        {
            while(index >= grid.RowDefinitions.Count)
            {
                grid.RowDefinitions.Add(new() { Height = GridLength.Auto });
            }
        }
        else
        {
            while(index >= grid.ColumnDefinitions.Count)
            {
                grid.ColumnDefinitions.Add(new() { Width = GridLength.Auto });
            }
        }
    }
}
