namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the editor aspect of the StageMonitoring plugin modules.</summary>
[CppInclude("StageMonitorEditorSettings.h")]
public partial class UStageMonitorEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Refresh rate in seconds for the StageMonitor panel.</summary>
	public float RefreshRate;
}
