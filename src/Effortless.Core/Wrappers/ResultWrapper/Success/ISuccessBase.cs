namespace Effortless.Core.Wrappers.ResultWrapper.Success;

/// <summary>
/// Represents a successful result of an operation with a payload.
/// </summary>
/// <typeparam name="T">The type of the payload.</typeparam>
public interface ISuccessBase<T>
{
    /// <summary>
    /// Gets or sets the payload associated with the successful result.
    /// </summary>
    T? Payload { get; set; }
}