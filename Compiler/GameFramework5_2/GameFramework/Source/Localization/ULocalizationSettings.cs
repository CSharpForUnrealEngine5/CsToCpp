#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationSettings.h")]
///<summary>Class for loading/saving configuration settings and the details view objects needed for localization dashboard functionality.</summary>
public partial class ULocalizationSettings : UObject {
// LocalizationSettings
	public ULocalizationTargetSet EngineTargetSet;
	public TArray<FLocalizationTargetSettings> EngineTargetsSettings;
	public ULocalizationTargetSet GameTargetSet;
	public TArray<FLocalizationTargetSettings> GameTargetsSettings;
}
