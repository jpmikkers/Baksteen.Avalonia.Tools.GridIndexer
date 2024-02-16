# Baksteen.Avalonia.Tools.GridIndexer
This avalonia component automatically arranges components on a Grid

## How to use
- Add nuget package Baksteen.Avalonia.Tools.GridIndexer
- In your Window xaml (containing the Grid you want to autoindex), add a namespace like so `xmlns:ex="using:Baksteen.Avalonia.Tools.GridIndexer"`
- In your Window cs file, add using statment `using Baksteen.Avalonia.Tools.GridIndexer;`
- In your Window codebehind, after `InitializeComponent()` add a call `GridIndexer.RunGridIndexer(this);`
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

