using Effortless.Core.Wrappers.ResultWrapper.Common;

namespace Effortless.Core.Wrappers.ResultWrapper.Failure;

public class FailureEmpty<T> : FailureBase<T>, IResultWrapper<T>
{
    T? IResultWrapper<T>.Payload { get; set; }
    object? IResultWrapper.Payload { get; set; }
    T? IResultWrapper<T>.Errors { get; set; }
    object? IResultWrapper.Errors { get; set; }
    bool IBaseWrapper.IsValid { get; set; }
    string? IBaseWrapper.Message { get; set; }
    int IBaseWrapper.Code { get; set; }
}
