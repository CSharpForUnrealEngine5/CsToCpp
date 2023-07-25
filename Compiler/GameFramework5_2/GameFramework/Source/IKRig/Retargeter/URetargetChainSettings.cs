#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargeter.h")]
public partial class URetargetChainSettings : UObject {
// RetargetChainSettings
	public string SourceChain;
	public string TargetChain;
	public FTargetChainSettings Settings;
	public bool CopyPoseUsingFK_DEPRECATED;
	public ERetargetRotationMode RotationMode_DEPRECATED;
	public float RotationAlpha_DEPRECATED;
	public ERetargetTranslationMode TranslationMode_DEPRECATED;
	public float TranslationAlpha_DEPRECATED;
	public bool DriveIKGoal_DEPRECATED;
	public float BlendToSource_DEPRECATED;
	public FVector BlendToSourceWeights_DEPRECATED;
	public FVector StaticOffset_DEPRECATED;
	public FVector StaticLocalOffset_DEPRECATED;
	public FRotator StaticRotationOffset_DEPRECATED;
	public float Extension_DEPRECATED;
	public bool UseSpeedCurveToPlantIK_DEPRECATED;
	public string SpeedCurveName_DEPRECATED;
	public float VelocityThreshold_DEPRECATED;
	public float UnplantStiffness_DEPRECATED;
	public float UnplantCriticalDamping_DEPRECATED;
}
