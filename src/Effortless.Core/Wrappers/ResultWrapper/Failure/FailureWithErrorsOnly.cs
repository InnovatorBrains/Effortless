using Effortless.Core.Wrappers.ResultWrapper.Common;

namespace Effortless.Core.Wrappers.ResultWrapper.Failure;

/// <summary>
/// Represents a failure result of an operation with errors only.
/// </summary>
/// <typeparam name="T">The type of the errors.</typeparam>
public class FailureWithErrorsOnly<T> : FailureBase<T>, IResultWrapper<T>
{
    /// <inheritdoc/>
    bool IBaseWrapper.IsValid { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FailureWithErrorsOnly{T}"/> class.
    /// </summary>
    /// <param name="errors">The errors associated with the failure.</param>
    public FailureWithErrorsOnly(T? errors = default)
    {
        Errors = errors;
        ((IResultWrapper)this).Errors = errors;
    }

    /// <inheritdoc/>
    string? IBaseWrapper.Message { get; set; }

    /// <inheritdoc/>
    int IBaseWrapper.Code { get; set; }

    /// <summary>
    /// Gets or sets the errors associated with the failure result.
    /// </summary>
    public T? Errors { get; set; }

    /// <inheritdoc/>
    T? IResultWrapper<T>.Payload { get; set; }
    object? IResultWrapper.Payload { get; set; }
    object? IResultWrapper.Errors { get; set; }
}
