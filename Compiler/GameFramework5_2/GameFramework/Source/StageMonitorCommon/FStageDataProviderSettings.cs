#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings associated to DataProviders</summary>
[CppInclude("StageMonitoringSettings.h")]
public partial struct FStageDataProviderSettings {
	public bool bUseRoleFiltering;
	public FGameplayTagContainer SupportedRoles;
	public TMap<FStageMessageTypeWrapper,FGameplayTagContainer> MessageTypeRoleExclusion;
	public FStageFramePerformanceSettings FramePerformanceSettings;
	public FStageHitchDetectionSettings HitchDetectionSettings;
}
