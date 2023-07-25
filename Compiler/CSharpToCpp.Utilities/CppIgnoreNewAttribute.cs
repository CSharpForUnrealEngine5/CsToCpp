namespace CSharpToCpp.Utilities
{
    /// <summary>
    /// Used when C# requires a new to initialize a 
    /// variable, but C++ needs stack semantics.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class CppIgnoreNewAttribute : Attribute
    {
    }
}
