# BlazorGrid

A reflection and attribute-driven column definition framework for Blazor Server.

## What is it?
BlazorGrid lets you define table columns directly on your C# model using attributes.
No manual column markup. No duplication. The model is the single source of truth.

## Example
```csharp
public class BeneficiaryViewModel
{
    [GridColumn(Label = "Full Name", IsSortable = true, Order = 1)]
    public string Name { get; set; }

    [GridColumn(Label = "Village", IsFilterable = true, Order = 2)]
    public string Village { get; set; }
}
```

## Status
🚧 In active development. Not yet available on NuGet.