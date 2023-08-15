namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class to allow the BP to call the custom setters and getters on FPCGAttributePropertySelector.</summary>
[CppInclude("Metadata/PCGAttributePropertySelector.h")]
public partial class UPCGAttributePropertySelectorBlueprintHelpers : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>SetPointProperty</summary>
	public static bool SetPointProperty(FPCGAttributePropertySelector Selector,EPCGPointProperties InPointProperty) { return default; }
	///<summary>SetAttributeName</summary>
	public static bool SetAttributeName(FPCGAttributePropertySelector Selector,FName InAttributeName) { return default; }
	///<summary>GetName</summary>
	public static FName GetName(FPCGAttributePropertySelector Selector) { return default; }
}
