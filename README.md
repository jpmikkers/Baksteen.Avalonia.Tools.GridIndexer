# Baksteen.Avalonia.Tools.GridIndexer
This avalonia component automatically arranges components on a Grid. It enables putting absolute and relative positioning hints on components in a Grid, which will save a lot of time when you have to rearrange or add things to the grid.

Note: This is an Avalonia port (with minor changes) of [Andrew KeepCoding's](https://github.com/AndrewKeepCoding) WinUI3 [GridIndexer](https://github.com/AndrewKeepCoding/AK.Toolkit)

## How to use
- Add nuget package Baksteen.Avalonia.Tools.GridIndexer
- In your Window xaml (containing the Grid you want to autoindex), add a namespace like so `xmlns:ex="using:Baksteen.Avalonia.Tools.GridIndexer"`
- In your Window csharp file, add using statement `using Baksteen.Avalonia.Tools.GridIndexer;`
- In your Window csharp file, after `InitializeComponent()` add a call `GridIndexer.RunGridIndexer(this);`
- on your Grid child components you can now add absolute or relative positioning properties, e.g. `ex:GI.Row="2"`, `ex:GI.Row="+1"`, `ex:GI.Column="4"`, `ex:GI.Column="-1"`

## Example

The following XAML results in the grid below:
```xaml
<Grid ColumnDefinitions="*,*,*,*,*,*,*,*,*,*,*" RowDefinitions="*,*,*,*,*,*,*,*,*,*,*">
    <Label Foreground="Green" ex:GI.Column="0" ex:GI.Row="0">·A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    <Label ex:GI.Column="+1" ex:GI.Row="+1">→↓A</Label>
    
    <Label Foreground="Green" ex:GI.Column="4" ex:GI.Row="6">·B</Label>
    <Label ex:GI.Row="+1">↓B</Label>
    <Label ex:GI.Row="+1">↓B</Label>
    <Label ex:GI.Row="+1">↓B</Label>
    <Label ex:GI.Row="+1">↓B</Label>
    <Label ex:GI.Column="-1">←B</Label>
    <Label ex:GI.Column="-1">←B</Label>
    <Label ex:GI.Column="-1">←B</Label>
    <Label ex:GI.Row="-1">↑B</Label>
    <Label ex:GI.Row="-1">↑B</Label>
    <Label ex:GI.Row="-1">↑B</Label>
    <Label ex:GI.Row="-1">↑B</Label>
    <Label ex:GI.Column="+1">→B</Label>
    <Label ex:GI.Column="+1">→B</Label>
</Grid>
```

![image](https://github.com/jpmikkers/Baksteen.Avalonia.Tools.GridIndexer/assets/10578746/fba02f9b-10d1-4b29-8924-42788d6722a1)

