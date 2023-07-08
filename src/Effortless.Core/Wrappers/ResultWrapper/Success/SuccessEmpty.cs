using Effortless.Core.Wrappers.ResultWrapper.Common;

namespace Effortless.Core.Wrappers.ResultWrapper.Success;
public class SuccessEmpty<T> : SuccessBase<T>, IResultWrapper<T>
{
    public SuccessEmpty() { }
    object? IResultWrapper.Payload { get; set; }
    object? IResultWrapper.Errors { get; set; }
    T? IResultWrapper<T>.Payload { get; set; }
    T? IResultWrapper<T>.Errors { get; set; }
    bool IBaseWrapper.IsValid { get; set; }
    string? IBaseWrapper.Message { get; set; }
    int IBaseWrapper.Code { get; set; }
}
