namespace CSharpToCpp.Utilities
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class CppRename : Attribute
    {
        public CppRename(string cppName)
        {
            CppName = cppName; 
        }

        public string CppName { get; }
    }
}
