namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings related to HitchDetection messages</summary>
[CppInclude("StageMonitoringSettings.h")]
public partial struct FStageHitchDetectionSettings {
	public bool bEnableHitchDetection;
	public FFrameRate MinimumFrameRate;
}
