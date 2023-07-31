#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A library of the most common animation blueprint functions.</summary>
[CppInclude("KismetAnimationLibrary.h")]
public partial class UKismetAnimationLibrary : UBlueprintFunctionLibrary {
	///<summary>Computes the transform for two bones using inverse kinematics.</summary>
	public static void K2_TwoBoneIK(FVector RootPos,FVector JointPos,FVector EndPos,FVector JointTarget,FVector Effector,FVector OutJointPos,FVector OutEndPos,bool bAllowStretching,float StartStretchRatio,float MaxStretchScale) {}
	///<summary>Computes the transform which is &quot;looking&quot; at target position with a local axis.</summary>
	public static FTransform K2_LookAt(FTransform CurrentTransform,FVector TargetPosition,FVector LookAtVector,bool bUseUpVector,FVector UpVector,float ClampConeInDegree) { return default; }
	///<summary>Computes the distance between two bones / sockets and can remap the range.</summary>
	public static float K2_DistanceBetweenTwoSocketsAndMapRange(USkeletalMeshComponent Component,string SocketOrBoneNameA,ERelativeTransformSpace SocketSpaceA,string SocketOrBoneNameB,ERelativeTransformSpace SocketSpaceB,bool bRemapRange,float InRangeMin,float InRangeMax,float OutRangeMin,float OutRangeMax) { return default; }
	///<summary>Computes the direction between two bones / sockets.</summary>
	public static FVector K2_DirectionBetweenSockets(USkeletalMeshComponent Component,string SocketOrBoneNameFrom,string SocketOrBoneNameTo) { return default; }
	///<summary>This function creates perlin noise from input X, Y, Z, and then range map to RangeOut, and out put to OutX, OutY, OutZ</summary>
	public static FVector K2_MakePerlinNoiseVectorAndRemap(float X,float Y,float Z,float RangeOutMinX,float RangeOutMaxX,float RangeOutMinY,float RangeOutMaxY,float RangeOutMinZ,float RangeOutMaxZ) { return default; }
	///<summary>This function creates perlin noise for a single float and then range map to RangeOut</summary>
	public static float K2_MakePerlinNoiseAndRemap(float Value,float RangeOutMin,float RangeOutMax) { return default; }
	///<summary>This function calculates the velocity of a position changing over time.</summary>
	public static float K2_CalculateVelocityFromPositionHistory(float DeltaSeconds,FVector Position,FPositionHistory History,int NumberOfSamples,float VelocityMin,float VelocityMax) { return default; }
	///<summary>This function calculates the velocity of an offset position on a bone / socket over time.</summary>
	public static float K2_CalculateVelocityFromSockets(float DeltaSeconds,USkeletalMeshComponent Component,string SocketOrBoneName,string ReferenceSocketOrBone,ERelativeTransformSpace SocketSpace,FVector OffsetInBoneSpace,FPositionHistory History,int NumberOfSamples,float VelocityMin,float VelocityMax,EEasingFuncType EasingType,FRuntimeFloatCurve CustomCurve) { return default; }
	///<summary>This function starts measuring the time for a profiling bracket</summary>
	public static void K2_StartProfilingTimer() {}
	///<summary>This function ends measuring a profiling bracket and optionally logs the result</summary>
	public static float K2_EndProfilingTimer(bool bLog/*=true*/,string LogPrefix/*=""*/) { return default; }
	///<summary>Returns degree of the angle between Velocity and Rotation forward vector</summary>
	public static float CalculateDirection(FVector Velocity,FRotator BaseRotation) { return default; }
}
