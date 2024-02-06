// User code
Console.WriteLine("original");
Console.WriteLine("original");

// Generated code
namespace InterceptorProject
{
    public static class Interceptor
    {
        [System.Runtime.CompilerServices.InterceptsLocation(
            filePath: @"C:\Users\DanielM\Documents\ISKA\Dotnet 8\Projects\InterceptorProject\InterceptorProject\Program.cs",
            line: 3,
            column: 9)]
        public static void InterceptWriteLine(string? message)
        {
            Console.WriteLine($"INTERCEPTED! Original message was '{message}'");
        }
    }
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    file sealed class InterceptsLocationAttribute(string filePath, int line, int column) : Attribute;
}

