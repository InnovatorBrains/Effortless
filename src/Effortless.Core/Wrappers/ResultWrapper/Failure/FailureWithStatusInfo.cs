using Effortless.Core.Wrappers.ResultWrapper.Common;

namespace Effortless.Core.Wrappers.ResultWrapper.Failure;

/// <summary>
/// Represents a failure result of an operation without errors.
/// </summary>
/// <typeparam name="T">The type of the errors.</typeparam>
public class FailureWithStatusInfo<T> : FailureBase<T>, IResultWrapper<T>
{
    /// <inheritdoc/>
    bool IBaseWrapper.IsValid { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FailureWithStatusInfo{T}"/> class with the specified error message and error code.
    /// </summary>
    /// <param name="errorMessage">The error message.</param>
    /// <param name="errorCode">The error code.</param>
    public FailureWithStatusInfo(string? errorMessage, int errorCode)
    {
        Message = errorMessage;
        Code = errorCode;
    }

    /// <summary>
    /// Gets or sets the error message associated with the failure result.
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets the error code associated with the failure result.
    /// </summary>
    public int Code { get; set; }

    /// <inheritdoc/>
    T? IResultWrapper<T>.Payload { get; set; }

    /// <inheritdoc/>
    T? IResultWrapper<T>.Errors { get; set; }
    object? IResultWrapper.Payload { get; set; }
    object? IResultWrapper.Errors { get; set; }
}
