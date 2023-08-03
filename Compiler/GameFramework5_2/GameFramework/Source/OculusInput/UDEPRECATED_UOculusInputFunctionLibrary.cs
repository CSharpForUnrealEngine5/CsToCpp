#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusInputFunctionLibrary.h")]
public partial class UDEPRECATED_UOculusInputFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>ConvertBoneToFinger</summary>
	public static EOculusFinger ConvertBoneToFinger(EBone Bone) { return default; }
	///<summary>GetHandSkeletalMesh</summary>
	public static bool GetHandSkeletalMesh(USkeletalMesh HandSkeletalMesh,EOculusHandType SkeletonType,EOculusHandType MeshType,float WorldToMeters/*=100.0f*/) { return default; }
	///<summary>InitializeHandPhysics</summary>
	public static TArray<FOculusCapsuleCollider> InitializeHandPhysics(EOculusHandType SkeletonType,USkinnedMeshComponent HandComponent,float WorldToMeters/*=100.0f*/) { return default; }
	///<summary>GetBoneRotation</summary>
	public static FQuat GetBoneRotation(EOculusHandType DeviceHand,EBone BoneId,int ControllerIndex/*=0*/) { return default; }
	///<summary>GetPointerPose</summary>
	public static FTransform GetPointerPose(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	///<summary>IsPointerPoseValid</summary>
	public static bool IsPointerPoseValid(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	///<summary>GetTrackingConfidence</summary>
	public static ETrackingConfidence GetTrackingConfidence(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	///<summary>GetFingerTrackingConfidence</summary>
	public static ETrackingConfidence GetFingerTrackingConfidence(EOculusHandType DeviceHand,EOculusFinger Finger,int ControllerIndex/*=0*/) { return default; }
	///<summary>GetHandScale</summary>
	public static float GetHandScale(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	///<summary>GetDominantHand</summary>
	public static EOculusHandType GetDominantHand(int ControllerIndex/*=0*/) { return default; }
	///<summary>IsHandTrackingEnabled</summary>
	public static bool IsHandTrackingEnabled() { return default; }
	///<summary>IsHandPositionValid</summary>
	public static bool IsHandPositionValid(EOculusHandType DeviceHand,int ControllerIndex/*=0*/) { return default; }
	///<summary>GetBoneName</summary>
	public static string GetBoneName(EBone BoneId) { return default; }
}
