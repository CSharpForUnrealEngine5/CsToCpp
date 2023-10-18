namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorProjectSettings.h")]
public partial class UDDCProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>EnableWarnings</summary>
	public bool EnableWarnings;
	///<summary>RecommendEveryoneSetupAGlobalLocalDDCPath</summary>
	public bool RecommendEveryoneSetupAGlobalLocalDDCPath;
	///<summary>RecommendEveryoneSetupAGlobalSharedDDCPath</summary>
	public bool RecommendEveryoneSetupAGlobalSharedDDCPath;
	///<summary>RecommendEveryoneSetupAGlobalS3DDCPath</summary>
	public bool RecommendEveryoneSetupAGlobalS3DDCPath;
	///<summary>RecommendEveryoneEnableS3DDC</summary>
	public bool RecommendEveryoneEnableS3DDC;
	///<summary>RecommendEveryoneUseUnrealCloudDDC</summary>
	public bool RecommendEveryoneUseUnrealCloudDDC;
}
