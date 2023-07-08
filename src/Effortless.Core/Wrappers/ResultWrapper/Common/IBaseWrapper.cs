namespace Effortless.Core.Wrappers.ResultWrapper.Common;

public interface IBaseWrapper
{
    /// <summary>
    /// Gets or sets a value indicating whether the service result is valid.
    /// </summary>
    public bool IsValid { get; set; }

    /// <summary>
    /// Gets or sets the message associated with the service result.
    /// </summary>
    public string? Message { get; set; }


    /// <summary>
    /// Gets or sets the code associated with the service result.
    /// </summary>
    public int Code { get; set; }
}
