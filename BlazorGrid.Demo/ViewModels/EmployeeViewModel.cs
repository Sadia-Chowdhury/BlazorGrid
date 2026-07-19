using BlazorGrid.Core;

namespace BlazorGrid.Demo.ViewModels;

public class EmployeeViewModel
{
    [GridColumn(Label = "Full Name", IsSortable = true, Order = 1)]
    public string Name { get; set; } = "";

    [GridColumn(Label = "Department", IsFilterable = true, Order = 2)]
    public string Department { get; set; } = "";

    [GridColumn(Label = "Email", Order = 3)]
    public string Email { get; set; } = "";

    public string InternalCode { get; set; } = ""; 
}