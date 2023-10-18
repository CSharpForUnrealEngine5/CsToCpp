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
