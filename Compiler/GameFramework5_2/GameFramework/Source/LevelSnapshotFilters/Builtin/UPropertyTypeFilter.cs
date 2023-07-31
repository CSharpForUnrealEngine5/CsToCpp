#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows a property if it is of a certain type.</summary>
[CppInclude("Builtin/PropertyTypeFilter.h")]
public partial class UPropertyTypeFilter : UPropertySelectorFilter {
	///<summary>The property types that you want to allow</summary>
	public TSet<EBlueprintPropertyType> AllowedTypes;
}
