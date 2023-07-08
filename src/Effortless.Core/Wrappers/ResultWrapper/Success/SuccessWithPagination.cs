using Effortless.Core.Wrappers.ResultWrapper.Common;

namespace Effortless.Core.Wrappers.ResultWrapper.Success;

/// <summary>
/// Represents a successful result of an operation with pagination.
/// </summary>
/// <typeparam name="T">The type of the payload.</typeparam>
public class SuccessWithPagination<T> : SuccessBase<T>, IResultWrapper<T>
{
    /// <inheritdoc/>
    bool IBaseWrapper.IsValid { get; set; } = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="SuccessWithPagination{T}"/> class with the specified payload and pagination information.
    /// </summary>
    /// <param name="payload">The payload associated with the successful result.</param>
    /// <param name="paginationInfo">The pagination information.</param>
    public SuccessWithPagination(T? payload, PaginationInfo? paginationInfo)
    {
        Payload = payload;
        PaginationInfo = paginationInfo;
        ((IResultWrapper)this).Payload = payload;
    }

    /// <inheritdoc/>
    string? IBaseWrapper.Message { get; set; }

    /// <inheritdoc/>
    int IBaseWrapper.Code { get; set; }

    /// <summary>
    /// Gets or sets the pagination information associated with the successful result.
    /// </summary>
    public PaginationInfo? PaginationInfo { get; set; }

    /// <inheritdoc/>
    public T? Payload { get; set; }

    /// <inheritdoc/>
    T? IResultWrapper<T>.Errors { get; set; }

    object? IResultWrapper.Payload { get; set; }
    object? IResultWrapper.Errors { get; set; }
}
