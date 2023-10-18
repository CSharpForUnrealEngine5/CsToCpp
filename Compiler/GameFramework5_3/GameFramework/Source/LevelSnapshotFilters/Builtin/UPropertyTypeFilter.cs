namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows a property if it is of a certain type.</summary>
[CppInclude("Builtin/PropertyTypeFilter.h")]
public partial class UPropertyTypeFilter : UPropertySelectorFilter {
	public static UClass StaticClass() {return default;}
	///<summary>The property types that you want to allow</summary>
	public TSet<EBlueprintPropertyType> AllowedTypes;
}
