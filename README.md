# Baksteen.Avalonia.Tools.GridIndexer
This avalonia component automatically arranges components on a Grid

## How to use
- Add nuget package Baksteen.Avalonia.Tools.GridIndexer
- In your Window xaml (containing the Grid you want to autoindex), add a namespace like so `xmlns:ex="using:Baksteen.Avalonia.Tools.GridIndexer"`
- In your Window cs file, add using statment `using Baksteen.Avalonia.Tools.GridIndexer;`
- In your Window codebehind, after `InitializeComponent()` add a call `GridIndexer.RunGridIndexer(this);`
- on your Grid child components you can now add absolute or relative positioning properties, e.g. `ex:GI.Row="2"`, `ex:GI.Row="+1"`, `ex:GI.Column="4"`, `ex:GI.Column="-1"`

