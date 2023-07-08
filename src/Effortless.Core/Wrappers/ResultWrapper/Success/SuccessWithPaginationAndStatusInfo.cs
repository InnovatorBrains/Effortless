using Effortless.Core.Wrappers.ResultWrapper.Common;

namespace Effortless.Core.Wrappers.ResultWrapper.Success;

/// <summary>
/// Represents a successful result of an operation with pagination and additional status information.
/// </summary>
/// <typeparam name="T">The type of the payload.</typeparam>
public class SuccessWithPaginationAndStatusInfo<T> : SuccessBase<T>, IResultWrapper<T>
{
    /// <inheritdoc/>
    bool IBaseWrapper.IsValid { get; set; } = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="SuccessWithPaginationAndStatusInfo{T}"/> class with the specified payload, success message, success code, and pagination information.
    /// </summary>
    /// <param name="payload">The payload associated with the successful result.</param>
    /// <param name="message">The success message.</param>
    /// <param name="code">The success code.</param>
    /// <param name="paginationInfo">The pagination information.</param>
    public SuccessWithPaginationAndStatusInfo(T? payload, string? message, int code, PaginationInfo? paginationInfo)
    {
        Payload = payload;
        PaginationInfo = paginationInfo;
        Message = message;
        Code = code;
        ((IResultWrapper)this).Payload = payload;
    }

    /// <inheritdoc/>
    public string? Message { get; set; }

    /// <inheritdoc/>
    public int Code { get; set; }

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