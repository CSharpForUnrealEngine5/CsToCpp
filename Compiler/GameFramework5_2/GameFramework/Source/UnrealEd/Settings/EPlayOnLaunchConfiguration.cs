namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorPlaySettings.h")]
///<summary>Configuration to use when launching on device.</summary>
public enum EPlayOnLaunchConfiguration {
	LaunchConfig_Default=0,
	LaunchConfig_Debug=1,
	LaunchConfig_Development=2,
	LaunchConfig_Test=3,
	LaunchConfig_Shipping=4,
}
