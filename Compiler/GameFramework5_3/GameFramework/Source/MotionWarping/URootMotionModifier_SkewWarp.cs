namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier_SkewWarp.h")]
public partial class URootMotionModifier_SkewWarp : URootMotionModifier_Warp {
	public static UClass StaticClass() {return default;}
	///<summary>AddRootMotionModifierSkewWarp</summary>
	public static URootMotionModifier_SkewWarp AddRootMotionModifierSkewWarp(UMotionWarpingComponent InMotionWarpingComp,UAnimSequenceBase InAnimation,float InStartTime,float InEndTime,FName InWarpTargetName,EWarpPointAnimProvider InWarpPointAnimProvider,FTransform InWarpPointAnimTransform,FName InWarpPointAnimBoneName,bool bInWarpTranslation/*=true*/,bool bInIgnoreZAxis/*=true*/,bool bInWarpRotation/*=true*/,EMotionWarpRotationType InRotationType/*=EMotionWarpRotationType.Default*/,EMotionWarpRotationMethod InRotationMethod/*=EMotionWarpRotationMethod.Slerp*/,float InWarpRotationTimeMultiplier/*=1.0f*/,float InWarpMaxRotationRate/*=0.0f*/) { return default; }
}
