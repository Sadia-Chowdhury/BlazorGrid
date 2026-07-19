# BlazorGrid

A reflection and attribute-driven column definition framework for Blazor Server.

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

    [GridColumn(Label = "Department", IsFilterable = true, Order = 2)]
    public string Department { get; set; }

    [GridColumn(Label = "Email", Order = 3)]
    public string Email { get; set; }

    public string InternalCode { get; set; } // no attribute — ignored automatically
}
```

Then use the component:

```razor
<BlazorGrid Items="@employees" T="EmployeeViewModel" />
```

That's it. BlazorGrid reads your model and renders the table automatically.

## Project Structure
- `BlazorGrid.Core` — attributes, column definitions, resolver engine
- `BlazorGrid.Components` — Razor components
- `BlazorGrid.Demo` — working Blazor Server demo app

## Status
🚧 In active development. Not yet available on NuGet.