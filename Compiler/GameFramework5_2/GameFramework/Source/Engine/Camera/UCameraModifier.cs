#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraModifier.h")]
///<summary>A CameraModifier is a base class for objects that may adjust the final camera properties after</summary>
public partial class UCameraModifier : UObject {
// CameraModifier
	public bool bDebug;
	public bool bExclusive;
	public byte Priority;
	public APlayerCameraManager CameraOwner;
	public float AlphaInTime;
	public float AlphaOutTime;
	public float Alpha;
	public void OnCameraOwnerDestroyed(UObject InOwner) {}
	public void BlueprintModifyCamera(float DeltaTime,FVector ViewLocation,FRotator ViewRotation,float FOV,FVector NewViewLocation,FRotator NewViewRotation,float NewFOV) {}
	public void BlueprintModifyPostProcess(float DeltaTime,float PostProcessBlendWeight,FPostProcessSettings PostProcessSettings) {}
	public bool IsDisabled() { return default; }
	public UObject GetViewTarget() { return default; }
	public void DisableModifier(bool bImmediate/*=false*/) {}
	public void EnableModifier() {}
}
