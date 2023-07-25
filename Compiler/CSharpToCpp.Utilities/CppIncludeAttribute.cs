namespace CSharpToCpp.Utilities
{
    [AttributeUsage( AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Struct,AllowMultiple = true)]
    public class CppIncludeAttribute : Attribute 
    {
        public CppIncludeAttribute(params string[] includeFilePath)
        {
            IncludeFilePath = new List<string>(includeFilePath);
        }

        public List<string> IncludeFilePath { get; }
    }
}