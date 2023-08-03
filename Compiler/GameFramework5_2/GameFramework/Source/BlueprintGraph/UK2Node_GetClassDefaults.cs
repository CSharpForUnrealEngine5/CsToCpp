#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_GetClassDefaults.h")]
public partial class UK2Node_GetClassDefaults : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>Blueprint that we subscribed OnBlueprintChangedDelegate and OnBlueprintCompiledDelegate to</summary>
	public UBlueprint BlueprintSubscribedTo;
	///<summary>Output pin visibility control</summary>
	public TArray<FOptionalPinFromProperty> ShowPinForProperties;
	///<summary>Whether or not to exclude object container properties</summary>
	public bool bExcludeObjectContainers;
	///<summary>Whether or not to exclude object array properties (deprecated)</summary>
	public bool bExcludeObjectArrays_DEPRECATED;
}
