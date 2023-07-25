#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeRecorderSettings.h")]
///<summary>Universal take recorder settings that apply to a whole take</summary>
public partial class UTakeRecorderUserSettings : UObject {
// TakeRecorderUserSettings
	public FTakeRecorderUserParameters Settings;
	public FDirectoryPath PresetSaveDir;
	public TSoftObjectPtr<UTakePreset> LastOpenedPreset;
	public bool bIsSequenceOpen;
	public bool bShowUserSettingsOnUI;
}
