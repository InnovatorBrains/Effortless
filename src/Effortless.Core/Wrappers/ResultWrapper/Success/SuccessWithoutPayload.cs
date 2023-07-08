using Effortless.Core.Wrappers.ResultWrapper.Common;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Effortless.Core.Wrappers.ResultWrapper.Success;

/// <summary>
/// Represents a successful result of an operation without a payload.
/// </summary>
/// <typeparam name="T">The type of the payload.</typeparam>
public class SuccessWithStatusInfo<T> : SuccessBase<T>, IResultWrapper<T>
{
    /// <inheritdoc/>
    bool IBaseWrapper.IsValid { get; set; } = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="SuccessWithStatusInfo{T}"/> class with the specified success message and success code.
    /// </summary>
    /// <param name="successMessage">The success message.</param>
    /// <param name="successCode">The success code.</param>
    public SuccessWithStatusInfo(string? successMessage, int successCode)
    {
        Message = successMessage;
        Code = successCode;
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
    T? IResultWrapper<T>.Payload { get; set; }

    /// <inheritdoc/>
    T? IResultWrapper<T>.Errors { get; set; }

    object? IResultWrapper.Payload { get; set; }
    object? IResultWrapper.Errors { get; set; }
}