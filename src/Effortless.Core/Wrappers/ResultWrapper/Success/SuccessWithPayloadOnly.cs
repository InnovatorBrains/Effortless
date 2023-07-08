using Effortless.Core.Wrappers.ResultWrapper.Common;

namespace Effortless.Core.Wrappers.ResultWrapper.Success;

/// <summary>
/// Represents a successful result of an operation with only a payload.
/// </summary>
/// <typeparam name="T">The type of the payload.</typeparam>
public class SuccessWithPayloadOnly<T> : SuccessBase<T>, IResultWrapper<T>
{
    /// <inheritdoc/>
    bool IBaseWrapper.IsValid { get; set; } = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="SuccessWithPayloadOnly{T}"/> class with the specified payload.
    /// </summary>
    /// <param name="payload">The payload associated with the successful result.</param>
    public SuccessWithPayloadOnly(T? payload = default)
    {
        Payload = payload;
        ((IResultWrapper)this).Payload = payload;
    }

    /// <inheritdoc/>
    public T? Payload { get; set; }

    /// <inheritdoc/>
    T? IResultWrapper<T>.Errors { get; set; }

    /// <inheritdoc/>
    string? IBaseWrapper.Message { get; set; }

    /// <inheritdoc/>
    int IBaseWrapper.Code { get; set; }

    object? IResultWrapper.Payload { get; set; }
    object? IResultWrapper.Errors { get; set; }
}