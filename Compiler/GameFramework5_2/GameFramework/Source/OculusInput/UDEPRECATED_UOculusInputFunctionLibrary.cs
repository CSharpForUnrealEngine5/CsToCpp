#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusInputFunctionLibrary.h")]
public partial class UDEPRECATED_UOculusInputFunctionLibrary : UBlueprintFunctionLibrary {
// UOculusInputFunctionLibrary
	public static EOculusFinger ConvertBoneToFinger(EBone Bone) { return default; }
	public static bool GetHandSkeletalMesh(USkeletalMesh HandSkeletalMesh,EOculusHandType SkeletonType,EOculusHandType MeshType,float WorldToMeters/*=100.0f*/) { return default; }
	public static TArray<FOculusCapsuleCollider> InitializeHandPhysics(EOculusHandType SkeletonType,USkinnedMeshComponent HandComponent,float WorldToMeters/*=100.0f*/) { return default; }
	public static FQuat GetBoneRotation(EOculusHandType DeviceHand,EBone BoneId,int ControllerIndex/*=0*/) { return default; }
	public static FTransform GetPointerPose(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public static bool IsPointerPoseValid(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public static ETrackingConfidence GetTrackingConfidence(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public static ETrackingConfidence GetFingerTrackingConfidence(EOculusHandType DeviceHand,EOculusFinger Finger,int ControllerIndex/*=0*/) { return default; }
	public static float GetHandScale(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public static EOculusHandType GetDominantHand(int ControllerIndex/*=0*/) { return default; }
	public static bool IsHandTrackingEnabled() { return default; }
	public static bool IsHandPositionValid(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public static string GetBoneName(EBone BoneId) { return default; }
}
