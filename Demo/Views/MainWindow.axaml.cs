namespace GridIndexerDemo.Views;

using Baksteen.Avalonia.Tools.GridIndexer;
using Avalonia.Controls;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        GridIndexer.RunGridIndexer(this);
    }
}