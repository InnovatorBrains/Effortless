namespace Effortless.Core.Wrappers.ResultWrapper.Failure;

/// <summary>
/// Represents a failure result of an operation with errors.
/// </summary>
/// <typeparam name="T">The type of the errors.</typeparam>
public interface IFailureBase<T>
{
    /// <summary>
    /// Gets or sets the errors associated with the failure result.
    /// </summary>
    T? Errors { get; set; }
}
