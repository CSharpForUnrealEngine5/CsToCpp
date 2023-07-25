#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputPlatformSettings.h")]
///<summary>Settings for Enhanced Input that can be set per-platform</summary>
public partial class UEnhancedInputPlatformSettings : UPlatformSettings {
// EnhancedInputPlatformSettings
	public TArray<TSoftObjectPtr<UClass>> InputData;
	public TArray<UClass> InputDataClasses;
	public bool bShouldLogMappingContextRedirects;
}
