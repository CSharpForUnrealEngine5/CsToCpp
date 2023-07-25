#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusInputFunctionLibrary.h")]
public partial class UDEPRECATED_UOculusInputFunctionLibrary : UBlueprintFunctionLibrary {
// UOculusInputFunctionLibrary
	public EOculusFinger ConvertBoneToFinger(EBone Bone) { return default; }
	public bool GetHandSkeletalMesh(UObject HandSkeletalMesh,EOculusHandType SkeletonType,EOculusHandType MeshType,float WorldToMeters/*=100.0f*/) { return default; }
	public TArray<FOculusCapsuleCollider> InitializeHandPhysics(EOculusHandType SkeletonType,UObject HandComponent,float WorldToMeters/*=100.0f*/) { return default; }
	public FQuat GetBoneRotation(EOculusHandType DeviceHand,EBone BoneId,int ControllerIndex/*=0*/) { return default; }
	public FTransform GetPointerPose(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public bool IsPointerPoseValid(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public ETrackingConfidence GetTrackingConfidence(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public ETrackingConfidence GetFingerTrackingConfidence(EOculusHandType DeviceHand,EOculusFinger Finger,int ControllerIndex/*=0*/) { return default; }
	public float GetHandScale(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public EOculusHandType GetDominantHand(int ControllerIndex/*=0*/) { return default; }
	public bool IsHandTrackingEnabled() { return default; }
	public bool IsHandPositionValid(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	public string GetBoneName(EBone BoneId) { return default; }
}
