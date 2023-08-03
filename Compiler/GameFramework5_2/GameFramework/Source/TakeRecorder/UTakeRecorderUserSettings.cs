#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Universal take recorder settings that apply to a whole take</summary>
[CppInclude("TakeRecorderSettings.h")]
public partial class UTakeRecorderUserSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>User settings that should be passed to a recorder instance</summary>
	public FTakeRecorderUserParameters Settings;
	///<summary>The default location in which to save take presets</summary>
	public FDirectoryPath PresetSaveDir;
	///<summary>Soft reference to the preset last opened on the take recording UI</summary>
	public TSoftObjectPtr<UTakePreset> LastOpenedPreset;
	///<summary>Whether the sequence editor is open for the take recorder</summary>
	public bool bIsSequenceOpen;
	///<summary>Whether the sequence editor is open for the take recorder</summary>
	public bool bShowUserSettingsOnUI;
}
