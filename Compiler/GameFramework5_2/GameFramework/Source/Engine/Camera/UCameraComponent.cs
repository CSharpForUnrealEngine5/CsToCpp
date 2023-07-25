#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraComponent.h")]
///<summary>Represents a camera viewpoint and settings, such as projection type, field of view, and post-process overrides.</summary>
public partial class UCameraComponent : USceneComponent {
// CameraComponent
	public float FieldOfView;
	public void SetFieldOfView(float InFieldOfView) {}
	public float OrthoWidth;
	public void SetOrthoWidth(float InOrthoWidth) {}
	public float OrthoNearClipPlane;
	public void SetOrthoNearClipPlane(float InOrthoNearClipPlane) {}
	public float OrthoFarClipPlane;
	public void SetOrthoFarClipPlane(float InOrthoFarClipPlane) {}
	public float AspectRatio;
	public void SetAspectRatio(float InAspectRatio) {}
	public bool bConstrainAspectRatio;
	public void SetConstraintAspectRatio(bool bInConstrainAspectRatio) {}
	public bool bUseFieldOfViewForLOD;
	public void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD) {}
	public string GetFilmbackText() { return default; }
	public bool bDrawFrustumAllowed;
	public bool bCameraMeshHiddenInGame;
	public bool bLockToHmd;
	public bool bUsePawnControlRotation;
	public byte ProjectionMode;
	public void SetProjectionMode(ECameraProjectionMode InProjectionMode) {}
	public void SetPostProcessBlendWeight(float InPostProcessBlendWeight) {}
	public void GetCameraView(float DeltaTime,FMinimalViewInfo DesiredView) {}
	public void AddOrUpdateBlendable(object /*InBlendableObject*/ InBlendableObject,float InWeight/*=1.0f*/) {}
	public void RemoveBlendable(object /*InBlendableObject*/ InBlendableObject) {}
	public UStaticMesh CameraMesh;
	public void OnCameraMeshHiddenChanged() {}
	public float PostProcessBlendWeight;
	public FPostProcessSettings PostProcessSettings;
	public bool bUseControllerViewRotation_DEPRECATED;
}
