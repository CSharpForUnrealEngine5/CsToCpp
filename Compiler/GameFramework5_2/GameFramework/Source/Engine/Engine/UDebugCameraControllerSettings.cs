namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default debug camera controller settings.</summary>
[CppInclude("Engine/DebugCameraControllerSettings.h")]
public partial class UDebugCameraControllerSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>CycleViewModes</summary>
	public TArray<FDebugCameraControllerSettingsViewModeIndex> CycleViewModes;
}
