#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the DisplayCluster StageMonitor hooks plugin modules.</summary>
[CppInclude("DisplayClusterStageMonitoringSettings.h")]
public partial class UDisplayClusterStageMonitoringSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Whether DWM hitch detection is enabled by default</summary>
	public bool bEnableDWMHitchDetection;
	///<summary>Whether Nvidia hitch detection is enabled by default</summary>
	public bool bEnableNvidiaHitchDetection;
}
