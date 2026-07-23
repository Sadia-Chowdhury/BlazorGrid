# GridFlow

[![NuGet](https://img.shields.io/nuget/v/GridFlow.svg)](https://www.nuget.org/packages/GridFlow)

A reflection and attribute-driven data grid library for Blazor Server.

## What is it?
GridFlow lets you define table columns directly on your C# model using attributes.
No manual column markup. No duplication. The model is the single source of truth.

## Installation
```
dotnet add package GridFlow
dotnet add package GridFlow.Components
```
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
            Title="Employee List"
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
- ✅ Configurable table title
- ✅ Bootstrap styled out of the box
- ✅ Pagination with page state management

## Project Structure
- `GridFlow.Core` — attributes, column definitions, resolver, sort state
- `GridFlow.Components` — Razor components
- `GridFlow.Demo` — working Blazor Server demo app

## Status
✅ v0.1.0 published on NuGet