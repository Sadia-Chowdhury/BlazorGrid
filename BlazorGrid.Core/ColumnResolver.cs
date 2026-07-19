using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BlazorGrid.Core;

public class ColumnResolver
{
    public List<ColumnDefinition> Resolve<T>()
    {
        var columns = new List<ColumnDefinition>();
        var properties = typeof(T).GetProperties();

        foreach (var property in properties)
        {
            var attribute = property.GetCustomAttribute<GridColumnAttribute>();

            if (attribute == null)
                continue;

            var column = new ColumnDefinition
            {
                DisplayName = attribute.Label,
                IsSortable = attribute.IsSortable,
                IsFilterable = attribute.IsFilterable,
                IsVisible = attribute.IsVisible,
                Order = attribute.Order,
                PropertyName = property.Name
            };

            columns.Add(column);
        }

        return columns.OrderBy(c => c.Order).ToList();
    }
    public List<ColumnDefinition> ResolveByType(Type type)
    {
        var columns = new List<ColumnDefinition>();
        var properties = type.GetProperties();

        foreach (var property in properties)
        {
            var attribute = property.GetCustomAttribute<GridColumnAttribute>();

            if (attribute == null)
                continue;

            var column = new ColumnDefinition
            {
                DisplayName = attribute.Label,
                IsSortable = attribute.IsSortable,
                IsFilterable = attribute.IsFilterable,
                IsVisible = attribute.IsVisible,
                Order = attribute.Order,
                PropertyName = property.Name
            };

            columns.Add(column);
        }

        return columns.OrderBy(c => c.Order).ToList();
    }
}