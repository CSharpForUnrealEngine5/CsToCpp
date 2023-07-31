#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a camera viewpoint and settings, such as projection type, field of view, and post-process overrides.</summary>
[CppInclude("Camera/CameraComponent.h")]
public partial class UCameraComponent : USceneComponent {
	///<summary>The horizontal field of view (in degrees) in perspective mode (ignored in Orthographic mode)</summary>
	public float FieldOfView;
	///<summary>SetFieldOfView</summary>
	public  void SetFieldOfView(float InFieldOfView) {}
	///<summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
	public float OrthoWidth;
	///<summary>SetOrthoWidth</summary>
	public  void SetOrthoWidth(float InOrthoWidth) {}
	///<summary>The near plane distance of the orthographic view (in world units)</summary>
	public float OrthoNearClipPlane;
	///<summary>SetOrthoNearClipPlane</summary>
	public  void SetOrthoNearClipPlane(float InOrthoNearClipPlane) {}
	///<summary>The far plane distance of the orthographic view (in world units)</summary>
	public float OrthoFarClipPlane;
	///<summary>SetOrthoFarClipPlane</summary>
	public  void SetOrthoFarClipPlane(float InOrthoFarClipPlane) {}
	///<summary>Aspect Ratio (Width/Height)</summary>
	public float AspectRatio;
	///<summary>SetAspectRatio</summary>
	public  void SetAspectRatio(float InAspectRatio) {}
	///<summary>If bConstrainAspectRatio is true, black bars will be added if the destination view has a different aspect ratio than this camera requested.</summary>
	public bool bConstrainAspectRatio;
	///<summary>SetConstraintAspectRatio</summary>
	public  void SetConstraintAspectRatio(bool bInConstrainAspectRatio) {}
	///<summary>If true, account for the field of view angle when computing which level of detail to use for meshes.</summary>
	public bool bUseFieldOfViewForLOD;
	///<summary>SetUseFieldOfViewForLOD</summary>
	public  void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD) {}
	///<summary>Returns the filmback text used for burnins on preview viewports</summary>
	public  string GetFilmbackText() { return default; }
	///<summary>The Frustum visibility flag for draw frustum component initialization</summary>
	public bool bDrawFrustumAllowed;
	///<summary>If the camera mesh is visible in game. Only relevant when running editor builds.</summary>
	public bool bCameraMeshHiddenInGame;
	///<summary>True if the camera&#39;s orientation and position should be locked to the HMD</summary>
	public bool bLockToHmd;
	///<summary>If this camera component is placed on a pawn, should it use the view/control rotation of the pawn where possible?</summary>
	public bool bUsePawnControlRotation;
	///<summary>The type of camera</summary>
	public ECameraProjectionMode ProjectionMode;
	///<summary>SetProjectionMode</summary>
	public  void SetProjectionMode(ECameraProjectionMode InProjectionMode) {}
	///<summary>SetPostProcessBlendWeight</summary>
	public  void SetPostProcessBlendWeight(float InPostProcessBlendWeight) {}
	///<summary>Returns camera&#39;s Point of View.</summary>
	public  void GetCameraView(float DeltaTime,FMinimalViewInfo DesiredView) {}
	///<summary>Adds an Blendable (implements IBlendableInterface) to the array of Blendables (if it doesn&#39;t exist) and update the weight</summary>
	public  void AddOrUpdateBlendable(object /*InBlendableObject*/ InBlendableObject,float InWeight/*=1.0f*/) {}
	///<summary>Removes a blendable.</summary>
	public  void RemoveBlendable(object /*InBlendableObject*/ InBlendableObject) {}
	///<summary>CameraMesh</summary>
	public UStaticMesh CameraMesh;
	///<summary>Internal function for updating the camera mesh visibility in PIE</summary>
	public  void OnCameraMeshHiddenChanged() {}
	///<summary>Indicates if PostProcessSettings should be used when using this Camera to view through.</summary>
	public float PostProcessBlendWeight;
	///<summary>Post process settings to use for this camera. Don&#39;t forget to check the properties you want to override</summary>
	public FPostProcessSettings PostProcessSettings;
	///<summary>DEPRECATED: use bUsePawnControlRotation instead</summary>
	public bool bUseControllerViewRotation_DEPRECATED;
}
