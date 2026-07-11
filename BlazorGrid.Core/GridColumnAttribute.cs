using System;

namespace BlazorGrid.Core;

[AttributeUsage(AttributeTargets.Property)]
public class GridColumnAttribute : Attribute
{
    public string Label { get; set; } = "";
    public bool IsSortable { get; set; } = false;
    public bool IsFilterable { get; set; } = false;
    public bool IsVisible { get; set; } = true;
    public int Order { get; set; } = 0;
}