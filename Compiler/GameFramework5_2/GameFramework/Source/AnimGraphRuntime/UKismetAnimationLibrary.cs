#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KismetAnimationLibrary.h")]
///<summary>A library of the most common animation blueprint functions.</summary>
public partial class UKismetAnimationLibrary : UBlueprintFunctionLibrary {
// KismetAnimationLibrary
	public static void K2_TwoBoneIK(FVector RootPos,FVector JointPos,FVector EndPos,FVector JointTarget,FVector Effector,FVector OutJointPos,FVector OutEndPos,bool bAllowStretching,float StartStretchRatio,float MaxStretchScale) {}
	public static FTransform K2_LookAt(FTransform CurrentTransform,FVector TargetPosition,FVector LookAtVector,bool bUseUpVector,FVector UpVector,float ClampConeInDegree) { return default; }
	public static float K2_DistanceBetweenTwoSocketsAndMapRange(USkeletalMeshComponent Component,string SocketOrBoneNameA,ERelativeTransformSpace SocketSpaceA,string SocketOrBoneNameB,ERelativeTransformSpace SocketSpaceB,bool bRemapRange,float InRangeMin,float InRangeMax,float OutRangeMin,float OutRangeMax) { return default; }
	public static FVector K2_DirectionBetweenSockets(USkeletalMeshComponent Component,string SocketOrBoneNameFrom,string SocketOrBoneNameTo) { return default; }
	public static FVector K2_MakePerlinNoiseVectorAndRemap(float X,float Y,float Z,float RangeOutMinX,float RangeOutMaxX,float RangeOutMinY,float RangeOutMaxY,float RangeOutMinZ,float RangeOutMaxZ) { return default; }
	public static float K2_MakePerlinNoiseAndRemap(float Value,float RangeOutMin,float RangeOutMax) { return default; }
	public static float K2_CalculateVelocityFromPositionHistory(float DeltaSeconds,FVector Position,FPositionHistory History,int NumberOfSamples,float VelocityMin,float VelocityMax) { return default; }
	public static float K2_CalculateVelocityFromSockets(float DeltaSeconds,USkeletalMeshComponent Component,string SocketOrBoneName,string ReferenceSocketOrBone,ERelativeTransformSpace SocketSpace,FVector OffsetInBoneSpace,FPositionHistory History,int NumberOfSamples,float VelocityMin,float VelocityMax,EEasingFuncType EasingType,FRuntimeFloatCurve CustomCurve) { return default; }
	public static void K2_StartProfilingTimer() {}
	public static float K2_EndProfilingTimer(bool bLog/*=true*/,string LogPrefix/*=""*/) { return default; }
	public static float CalculateDirection(FVector Velocity,FRotator BaseRotation) { return default; }
}
