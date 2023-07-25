namespace CSharpToCpp.Utilities;
/// <summary>
/// Used for methods that must return a const value
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public class CppConstAttribute : Attribute
{
}
