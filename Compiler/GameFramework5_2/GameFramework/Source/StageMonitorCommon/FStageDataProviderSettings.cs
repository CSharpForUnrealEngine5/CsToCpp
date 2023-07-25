#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageMonitoringSettings.h")]
///<summary>Settings associated to DataProviders</summary>
public partial struct FStageDataProviderSettings {
// StageDataProviderSettings
	public bool bUseRoleFiltering;
	public FGameplayTagContainer SupportedRoles;
	public TMap<FStageMessageTypeWrapper,FGameplayTagContainer> MessageTypeRoleExclusion;
	public FStageFramePerformanceSettings FramePerformanceSettings;
	public FStageHitchDetectionSettings HitchDetectionSettings;
}
