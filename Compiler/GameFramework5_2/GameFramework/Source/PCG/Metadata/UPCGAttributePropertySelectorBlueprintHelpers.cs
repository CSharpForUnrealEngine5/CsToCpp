#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class to allow the BP to call the custom setters and getters on FPCGAttributePropertySelector.</summary>
[CppInclude("Metadata/PCGAttributePropertySelector.h")]
public partial class UPCGAttributePropertySelectorBlueprintHelpers : UBlueprintFunctionLibrary {
	///<summary>SetPointProperty</summary>
	public static bool SetPointProperty(FPCGAttributePropertySelector Selector,EPCGPointProperties InPointProperty) { return default; }
	///<summary>SetAttributeName</summary>
	public static bool SetAttributeName(FPCGAttributePropertySelector Selector,string InAttributeName) { return default; }
	///<summary>GetName</summary>
	public static string GetName(FPCGAttributePropertySelector Selector) { return default; }
}
