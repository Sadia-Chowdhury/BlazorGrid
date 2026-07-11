namespace BlazorGrid.Core;

public class ColumnDefinition
{
    public string DisplayName { get; set; } = "";
    public bool IsVisible { get; set; } = true;
    public bool IsSortable { get; set; } = false;
    public bool IsFilterable { get; set; } = false;
    public int Order { get; set; } = 0;
    public string PropertyName { get; set; } = "";
}