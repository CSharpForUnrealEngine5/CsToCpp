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
	///<summary>SetExtraProperty</summary>
	public static bool SetExtraProperty(FPCGAttributePropertySelector Selector,EPCGExtraProperties InExtraProperty) { return default; }
	///<summary>GetSelection</summary>
	public static EPCGAttributePropertySelection GetSelection(FPCGAttributePropertySelector Selector) { return default; }
	///<summary>GetPointProperty</summary>
	public static EPCGPointProperties GetPointProperty(FPCGAttributePropertySelector Selector) { return default; }
	///<summary>GetAttributeName</summary>
	public static FName GetAttributeName(FPCGAttributePropertySelector Selector) { return default; }
	///<summary>GetExtraProperty</summary>
	public static EPCGExtraProperties GetExtraProperty(FPCGAttributePropertySelector Selector) { return default; }
	///<summary>GetExtraNames</summary>
	public static TArray<string> GetExtraNames(FPCGAttributePropertySelector Selector) { return default; }
	///<summary>GetName</summary>
	public static FName GetName(FPCGAttributePropertySelector Selector) { return default; }
	///<summary>CopyAndFixLast</summary>
	public static FPCGAttributePropertyInputSelector CopyAndFixLast(FPCGAttributePropertyInputSelector Selector,UPCGData InData) { return default; }
	///<summary>CopyAndFixSource</summary>
	public static FPCGAttributePropertyOutputSelector CopyAndFixSource(FPCGAttributePropertyOutputSelector Selector,FPCGAttributePropertyInputSelector InSelector) { return default; }
}
