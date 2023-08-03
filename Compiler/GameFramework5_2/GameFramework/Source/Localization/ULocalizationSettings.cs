#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class for loading/saving configuration settings and the details view objects needed for localization dashboard functionality.</summary>
[CppInclude("LocalizationSettings.h")]
public partial class ULocalizationSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>EngineTargetSet</summary>
	public ULocalizationTargetSet EngineTargetSet;
	///<summary>EngineTargetsSettings</summary>
	public TArray<FLocalizationTargetSettings> EngineTargetsSettings;
	///<summary>GameTargetSet</summary>
	public ULocalizationTargetSet GameTargetSet;
	///<summary>GameTargetsSettings</summary>
	public TArray<FLocalizationTargetSettings> GameTargetsSettings;
}
