#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargeter.h")]
public partial class URetargetChainSettings : UObject {
	///<summary>The chain on the Source IK Rig asset to copy animation FROM.</summary>
	public string SourceChain;
	///<summary>The chain on the Target IK Rig asset to copy animation TO.</summary>
	public string TargetChain;
	///<summary>The settings used to control the motion on this target chain.</summary>
	public FTargetChainSettings Settings;
	///<summary>Deprecated properties from before FTargetChainSettings / profile refactor  (July 2022)</summary>
	public bool CopyPoseUsingFK_DEPRECATED;
	///<summary>RotationMode_DEPRECATED</summary>
	public ERetargetRotationMode RotationMode_DEPRECATED;
	///<summary>RotationAlpha_DEPRECATED</summary>
	public float RotationAlpha_DEPRECATED;
	///<summary>TranslationMode_DEPRECATED</summary>
	public ERetargetTranslationMode TranslationMode_DEPRECATED;
	///<summary>TranslationAlpha_DEPRECATED</summary>
	public float TranslationAlpha_DEPRECATED;
	///<summary>DriveIKGoal_DEPRECATED</summary>
	public bool DriveIKGoal_DEPRECATED;
	///<summary>BlendToSource_DEPRECATED</summary>
	public float BlendToSource_DEPRECATED;
	///<summary>BlendToSourceWeights_DEPRECATED</summary>
	public FVector BlendToSourceWeights_DEPRECATED;
	///<summary>StaticOffset_DEPRECATED</summary>
	public FVector StaticOffset_DEPRECATED;
	///<summary>StaticLocalOffset_DEPRECATED</summary>
	public FVector StaticLocalOffset_DEPRECATED;
	///<summary>StaticRotationOffset_DEPRECATED</summary>
	public FRotator StaticRotationOffset_DEPRECATED;
	///<summary>Extension_DEPRECATED</summary>
	public float Extension_DEPRECATED;
	///<summary>UseSpeedCurveToPlantIK_DEPRECATED</summary>
	public bool UseSpeedCurveToPlantIK_DEPRECATED;
	///<summary>SpeedCurveName_DEPRECATED</summary>
	public string SpeedCurveName_DEPRECATED;
	///<summary>VelocityThreshold_DEPRECATED</summary>
	public float VelocityThreshold_DEPRECATED;
	///<summary>UnplantStiffness_DEPRECATED</summary>
	public float UnplantStiffness_DEPRECATED;
	///<summary>UnplantCriticalDamping_DEPRECATED</summary>
	public float UnplantCriticalDamping_DEPRECATED;
}
