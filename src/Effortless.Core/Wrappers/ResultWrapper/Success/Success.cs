using Effortless.Core.Wrappers.ResultWrapper.Common;

namespace Effortless.Core.Wrappers.ResultWrapper.Success;

/// <summary>
/// Represents a successful result of an operation with a payload.
/// </summary>
/// <typeparam name="T">The type of the payload.</typeparam>
public class Success<T> : SuccessBase<T>, IResultWrapper<T>
{
    /// <inheritdoc/>
    bool IBaseWrapper.IsValid { get; set; } = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="Success{T}"/> class with the specified payload, success message, and success code.
    /// </summary>
    /// <param name="payload">The payload associated with the successful result.</param>
    /// <param name="successMessage">The success message.</param>
    /// <param name="successCode">The success code.</param>
    public Success(T? payload, string? successMessage, int successCode)
    {
        Payload = payload;
        Message = successMessage;
        Code = successCode;
        ((IResultWrapper)this).Payload = payload;
    }

    /// <summary>
    /// Gets or sets the message associated with the successful result.
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets the code associated with the successful result.
    /// </summary>
    public int Code { get; set; }

    /// <inheritdoc/>
    public T? Payload { get; set; }

    /// <inheritdoc/>
    T? IResultWrapper<T>.Errors { get; set; }
    object? IResultWrapper.Payload { get; set; }
    object? IResultWrapper.Errors { get; set; }
}
