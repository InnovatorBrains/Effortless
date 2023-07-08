using Serilog;

namespace Effortless.Core.Services.Logger;
public class LoggerService
{
    public static void EnsureInitialized()
    {
        if (Log.Logger is not Serilog.Core.Logger)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        }
    }
}
