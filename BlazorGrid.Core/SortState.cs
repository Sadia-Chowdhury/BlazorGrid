namespace BlazorGrid.Core;

public class SortState
{
    public string ColumnName { get; set; } = "";
    public SortDirection Direction { get; set; } = SortDirection.Ascending;
}