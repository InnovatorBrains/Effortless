namespace Effortless.Core.Wrappers.ResultWrapper.Failure;

// Generic Implementation

/// <summary>
/// Represents a base class for failure result of an operation with errors.
/// </summary>
/// <typeparam name="T">The type of the errors.</typeparam>
public abstract class FailureBase<T> : IFailureBase<T>
{
    /// <inheritdoc/>
    T? IFailureBase<T>.Errors { get; set; }
}
