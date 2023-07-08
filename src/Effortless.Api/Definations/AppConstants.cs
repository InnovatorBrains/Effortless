using System.Reflection;

namespace Effortless.Api.Definations;

public class AppConstants
{
    public static class AssemblyInfo
    {
        public static string? Name = Assembly.GetExecutingAssembly().GetName().Name;
    }
}
