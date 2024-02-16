using Avalonia;
using Avalonia.Controls;

namespace Baksteen.Avalonia.Tools.GridIndexer;

// see https://github.com/AndrewKeepCoding/AK.Toolkit/tree/main/WinUI3/AK.Toolkit.WinUI3.GridIndexer
public sealed class GI : AvaloniaObject
{
    public static readonly AvaloniaProperty<string> RowProperty = AvaloniaProperty.RegisterAttached<Grid, string>(
        "Row",
        typeof(GI));

    public static readonly AvaloniaProperty<string> ColumnProperty = AvaloniaProperty.RegisterAttached<Grid, string>(
        "Column",
        typeof(GI));

    public enum IndexTarget
    {
        Row,
        Column,
    }

    public enum ValueType
    {
        Absolute,
        Relative,
    }

    public static string GetRow(AvaloniaObject obj) => obj.GetValue(RowProperty) as string ?? string.Empty;

    public static void SetRow(AvaloniaObject obj, string value) => obj.SetValue(RowProperty, value);

    public static string GetColumn(AvaloniaObject obj) => obj.GetValue(ColumnProperty) as string ?? string.Empty;

    public static void SetColumn(AvaloniaObject obj, string value) => obj.SetValue(ColumnProperty, value);

    public static (ValueType ValueType, int Value)? GetTypeAndValue(AvaloniaObject target, IndexTarget indexTarget)
    {
        if( target.GetValue(indexTarget is IndexTarget.Row ? RowProperty : ColumnProperty) is string stringValue &&
            stringValue.Length > 0)
        {
            if((stringValue.StartsWith('+') is true || stringValue.StartsWith('-') is true) &&
                int.TryParse(stringValue, out int relativeValue) is true)
            {
                return (ValueType.Relative, relativeValue);
            }
            else if(int.TryParse(stringValue, out int absoluteValue) is true)
            {
                return (ValueType.Absolute, absoluteValue);
            }

            throw new GridIndexerException($"Failed to get type and value from '{stringValue}').");
        }

        return null;
    }
}
