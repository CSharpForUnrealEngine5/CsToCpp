namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Data Registry subsystem, these settings are used to scan for registry assets and set runtime access rules</summary>
[CppInclude("DataRegistrySettings.h")]
public partial class UDataRegistrySettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>List of directories to scan for data registry assets</summary>
	public TArray<FDirectoryPath> DirectoriesToScan;
	///<summary>If false, only registry assets inside DirectoriesToScan will be initialized. If true, it will also initialize any in-memory DataRegistry assets outside the scan paths</summary>
	public bool bInitializeAllLoadedRegistries;
	///<summary>If true, cooked builds will ignore errors with missing AssetRegistry data for specific registered assets like DataTables as it may have been stripped out</summary>
	public bool bIgnoreMissingCookedAssetRegistryData;
}
