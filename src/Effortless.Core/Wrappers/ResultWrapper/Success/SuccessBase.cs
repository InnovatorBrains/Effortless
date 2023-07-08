namespace Effortless.Core.Wrappers.ResultWrapper.Success;

/// <summary>
/// An abstract base class implementing the <see cref="ISuccessBase{T}"/> interface.
/// </summary>
/// <typeparam name="T">The type of the payload.</typeparam>
public abstract class SuccessBase<T> : ISuccessBase<T>
{
    /// <inheritdoc/>
    T? ISuccessBase<T>.Payload { get; set; }
}
