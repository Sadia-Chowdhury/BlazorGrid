namespace BlazorGrid.Core;

public class PaginationState
{
    public int PageSize { get; set; } = 10;
    public int PageNumber { get; set; } = 1;
    public int TotalCount { get; set; } = 0;
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
    public bool HasPreviousPage => PageNumber > 1;
    public bool HasNextPage => PageNumber < TotalPages;
}