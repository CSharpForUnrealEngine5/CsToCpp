#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A CameraModifier is a base class for objects that may adjust the final camera properties after</summary>
[CppInclude("Camera/CameraModifier.h")]
public partial class UCameraModifier : UObject {
	///<summary>If true, enables certain debug visualization features.</summary>
	public bool bDebug;
	///<summary>If true, no other modifiers of same priority allowed.</summary>
	public bool bExclusive;
	///<summary>Priority value that determines the order in which modifiers are applied. 0 = highest priority, 255 = lowest.</summary>
	public byte Priority;
	///<summary>Camera this object is associated with.</summary>
	public APlayerCameraManager CameraOwner;
	///<summary>When blending in, alpha proceeds from 0 to 1 over this time</summary>
	public float AlphaInTime;
	///<summary>When blending out, alpha proceeds from 1 to 0 over this time</summary>
	public float AlphaOutTime;
	///<summary>Current blend alpha.</summary>
	public float Alpha;
	///<summary>OnCameraOwnerDestroyed</summary>
	public  void OnCameraOwnerDestroyed(AActor InOwner) {}
	///<summary>Called per tick that the modifier is active to allow Blueprinted modifiers to modify the camera&#39;s transform.</summary>
	public  void BlueprintModifyCamera(float DeltaTime,FVector ViewLocation,FRotator ViewRotation,float FOV,FVector NewViewLocation,FRotator NewViewRotation,float NewFOV) {}
	///<summary>Called per tick that the modifier is active to allow Blueprinted modifiers to modify the camera&#39;s postprocess effects.</summary>
	public  void BlueprintModifyPostProcess(float DeltaTime,float PostProcessBlendWeight,FPostProcessSettings PostProcessSettings) {}
	///<summary>@return Returns true if modifier is disabled, false otherwise.</summary>
	public  bool IsDisabled() { return default; }
	///<summary>@return Returns the actor the camera is currently viewing.</summary>
	public  AActor GetViewTarget() { return default; }
	///<summary>Disables this modifier.</summary>
	public  void DisableModifier(bool bImmediate/*=false*/) {}
	///<summary>Enables this modifier.</summary>
	public  void EnableModifier() {}
}
