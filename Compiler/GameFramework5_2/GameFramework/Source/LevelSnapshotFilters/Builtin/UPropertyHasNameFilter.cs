#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/PropertyHasNameFilter.h")]
///<summary>Allows a property when is has a certain name</summary>
public partial class UPropertyHasNameFilter : UPropertySelectorFilter {
// PropertyHasNameFilter
	public ENameMatchingRule NameMatchingRule;
	public bool bIncludeStructSubproperties;
	public TSet<string> AllowedNames;
}
