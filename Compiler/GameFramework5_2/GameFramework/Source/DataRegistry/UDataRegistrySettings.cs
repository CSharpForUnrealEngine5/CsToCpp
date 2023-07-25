#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistrySettings.h")]
///<summary>Settings for the Data Registry subsystem, these settings are used to scan for registry assets and set runtime access rules</summary>
public partial class UDataRegistrySettings : UDeveloperSettings {
// DataRegistrySettings
	public TArray<FDirectoryPath> DirectoriesToScan;
	public bool bInitializeAllLoadedRegistries;
	public bool bIgnoreMissingCookedAssetRegistryData;
}
