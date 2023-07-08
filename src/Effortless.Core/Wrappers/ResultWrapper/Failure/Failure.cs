using Effortless.Core.Wrappers.ResultWrapper.Common;

namespace Effortless.Core.Wrappers.ResultWrapper.Failure;

/// <summary>
/// Represents a failure result of an operation with errors.
/// </summary>
/// <typeparam name="T">The type of the errors.</typeparam>
public class Failure<T> : FailureBase<T>, IResultWrapper<T>
{
    /// <inheritdoc/>
    bool IBaseWrapper.IsValid { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Failure{T}"/> class with the specified errors, error message, and error code.
    /// </summary>
    /// <param name="errors">The errors associated with the failure.</param>
    /// <param name="message">The error message.</param>
    /// <param name="code">The error code.</param>
    public Failure(T? errors, string? message, int code)
    {
        Errors = errors;
        Message = message;
        Code = code;
        ((IResultWrapper)this).Errors = errors;
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

    /// <summary>
    /// Gets or sets the errors associated with the failure result.
    /// </summary>
    public T? Errors { get; set; }

    object? IResultWrapper.Payload { get; set; }
    object? IResultWrapper.Errors { get; set; }
}
