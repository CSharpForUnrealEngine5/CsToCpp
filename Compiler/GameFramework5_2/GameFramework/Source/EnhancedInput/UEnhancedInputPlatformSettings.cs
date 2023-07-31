#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Enhanced Input that can be set per-platform</summary>
[CppInclude("EnhancedInputPlatformSettings.h")]
public partial class UEnhancedInputPlatformSettings : UPlatformSettings {
	///<summary>Input data that can be populated with Enhanced Input Platform Data blueprints</summary>
	public TArray<TSoftObjectPtr<UClass>> InputData;
	///<summary>A transient array of the subclasses for the Enhanced Input Platform data. This will prevent us from</summary>
	public TArray<UClass> InputDataClasses;
	///<summary>If true, then Enhanced Input will log which mapping contexts have been redirected when building the control mappings.</summary>
	public bool bShouldLogMappingContextRedirects;
}
