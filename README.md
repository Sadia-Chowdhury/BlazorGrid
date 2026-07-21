# BlazorGrid

A reflection and attribute-driven data grid library for Blazor Server.

## What is it?
BlazorGrid lets you define table columns directly on your C# model using attributes.
No manual column markup. No duplication. The model is the single source of truth.

## How it works
Decorate your ViewModel properties with `[GridColumn]`:

```csharp
public class EmployeeViewModel
{
    [GridColumn(Label = "Full Name", IsSortable = true, Order = 1)]
    public string Name { get; set; }

    [GridColumn(Label = "Department", IsSortable = true, IsFilterable = true, Order = 2)]
    public string Department { get; set; }

    [GridColumn(Label = "Email", IsSortable = true, Order = 3)]
    public string Email { get; set; }

    public string InternalCode { get; set; } // no attribute — ignored automatically
}
```

Then use the component:

```razor
<BlazorGrid Items="@employees" 
            T="EmployeeViewModel"
            OnSortChanged="HandleSort" />
```

Handle sorting in your page:

```csharp
private void HandleSort(SortState sort)
{
    // sort.ColumnName = "Name"
    // sort.Direction = Ascending or Descending
    // pass to your stored procedure, EF Core, or Dapper
}
```

## Features
- ✅ Attribute-driven column resolution
- ✅ Column visibility toggle
- ✅ Sort state management with direction indicator

## Project Structure
- `BlazorGrid.Core` — attributes, column definitions, resolver, sort state
- `BlazorGrid.Components` — Razor components
- `BlazorGrid.Demo` — working Blazor Server demo app

## Status
🚧 In active development. Not yet available on NuGet.