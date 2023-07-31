#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for StageMonitor</summary>
[CppInclude("StageMonitoringSettings.h")]
public partial struct FStageMonitorSettings {
	public bool bUseRoleFiltering;
	public FGameplayTagContainer SupportedRoles;
	public float DiscoveryMessageInterval;
	public bool bAutoStart;
}
