#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows a property when is has a certain name</summary>
[CppInclude("Builtin/PropertyHasNameFilter.h")]
public partial class UPropertyHasNameFilter : UPropertySelectorFilter {
	///<summary>How to compare the property name to AllowedNames</summary>
	public ENameMatchingRule NameMatchingRule;
	///<summary>Whether to implicitly include sub-properties of structs.</summary>
	public bool bIncludeStructSubproperties;
	///<summary>The names to match the property name against.</summary>
	public TSet<string> AllowedNames;
}
