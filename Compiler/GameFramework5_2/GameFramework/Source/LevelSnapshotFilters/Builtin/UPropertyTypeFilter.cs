#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builtin/PropertyTypeFilter.h")]
///<summary>Allows a property if it is of a certain type.</summary>
public partial class UPropertyTypeFilter : UPropertySelectorFilter {
// PropertyTypeFilter
	public TSet<EBlueprintPropertyType> AllowedTypes;
}
