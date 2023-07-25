#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMonitoringSettings.h")]
///<summary>Settings for StageMonitor</summary>
public partial struct FStageMonitorSettings {
// StageMonitorSettings
	public bool bUseRoleFiltering;
	public FGameplayTagContainer SupportedRoles;
	public float DiscoveryMessageInterval;
	public bool bAutoStart;
}
