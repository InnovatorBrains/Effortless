using Effortless.Core.Wrappers.ResultWrapper.Common;
using Effortless.Core.Wrappers.ResultWrapper.Failure;
using Effortless.Core.Wrappers.ResultWrapper.Success;

namespace Effortless.Core.Wrappers.ResultWrapper;

/// <summary>
/// A static class that provides methods for creating service result responses.
/// </summary>
public static class ResultWrapper
{
    // Generic Overloads for Success
    public static IResultWrapper<TPayload> Success<TPayload>()
    {
        return new SuccessEmpty<TPayload>();
    }
    public static IResultWrapper<TPayload> Success<TPayload>(string? message, int code)
    {
        return new SuccessWithStatusInfo<TPayload>(message, code);
    }
    public static IResultWrapper<TPayload> Success<TPayload>(TPayload? payload)
    {
        return new SuccessWithPayloadOnly<TPayload>(payload);
    }

    public static IResultWrapper<TPayload> Success<TPayload>(TPayload? payload, string? message, int code)
    {
        return new Success<TPayload>(payload, message, code);
    }

    // Non Generic Overloads for Success

    public static IBaseWrapper Success()
    {
        return new SuccessEmpty<object>();
    }
    public static IBaseWrapper Success(string? message, int code)
    {
        return new SuccessWithStatusInfo<object>(message, code);
    }
    public static IBaseWrapper Success(object? payload)
    {
        return new SuccessWithPayloadOnly<object>(payload);
    }
    public static IBaseWrapper Success(object? payload, string? message, int code)
    {
        return new Success<object>(payload, message, code);
    }

    // Generic Overloads for Failure
    public static IResultWrapper<TErrors> Failure<TErrors>()
    {
        return new FailureEmpty<TErrors>();
    }

    public static IResultWrapper<TErrors> Failure<TErrors>(string? message, int code)
    {
        return new FailureWithStatusInfo<TErrors>(message, code);
    }

    public static IResultWrapper<TErrors> Failure<TErrors>(TErrors? errors)
    {
        return new FailureWithErrorsOnly<TErrors>(errors);
    }

    public static IResultWrapper<TErrors> Failure<TErrors>(string? message, int code, TErrors? errors)
    {
        return new Failure<TErrors>(errors, message, code);
    }

    // Non Generic Overloads for Failure

    public static IBaseWrapper Failure()
    {
        return new FailureEmpty<object>();
    }

    public static IBaseWrapper Failure(string? message, int code)
    {
        return new FailureWithStatusInfo<object>(message, code);
    }

    public static IBaseWrapper Failure(object? errors)
    {
        return new FailureWithErrorsOnly<object>(errors);
    }

    public static IBaseWrapper Failure(string? message, int code, object? errors)
    {
        return new Failure<object>(errors, message, code);
    }
}
