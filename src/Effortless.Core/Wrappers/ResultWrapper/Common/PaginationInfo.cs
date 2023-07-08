namespace Effortless.Core.Wrappers.ResultWrapper.Common;

/// <summary>
/// Represents pagination information.
/// </summary>
public sealed class PaginationInfo
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaginationInfo"/> class with the specified total count, page count, current page, and page size.
    /// </summary>
    /// <param name="totalCount">The total count of items.</param>
    /// <param name="pageCount">The total count of pages.</param>
    /// <param name="currentPage">The current page.</param>
    /// <param name="pageSize">The page size.</param>
    public PaginationInfo(int? totalCount, int? pageCount, int? currentPage, int? pageSize)
    {
        TotalCount = totalCount;
        PageCount = pageCount;
        CurrentPage = currentPage;
        PageSize = pageSize;
    }

    /// <summary>
    /// Gets or sets the total count of items.
    /// </summary>
    public int? TotalCount { get; set; }

    /// <summary>
    /// Gets or sets the total count of pages.
    /// </summary>
    public int? PageCount { get; set; }

    /// <summary>
    /// Gets or sets the current page.
    /// </summary>
    public int? CurrentPage { get; set; }

    /// <summary>
    /// Gets or sets the page size.
    /// </summary>
    public int? PageSize { get; set; }
}