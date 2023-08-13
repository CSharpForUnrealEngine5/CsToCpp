namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>3D point in space used to render nDisplay viewports from</summary>
[CppInclude("Components/DisplayClusterCameraComponent.h")]
public partial class UDisplayClusterCameraComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Get interpupillary distance</summary>
	public float GetInterpupillaryDistance() { return default; }
	///<summary>Set interpupillary distance</summary>
	public void SetInterpupillaryDistance(float Distance) {}
	///<summary>Get swap eyes state</summary>
	public bool GetSwapEyes() { return default; }
	///<summary>Set swap eyes state</summary>
	public void SetSwapEyes(bool SwapEyes) {}
	///<summary>Toggles eyes swap state</summary>
	public bool ToggleSwapEyes() { return default; }
	///<summary>Get stereo offset type</summary>
	public EDisplayClusterEyeStereoOffset GetStereoOffset() { return default; }
	///<summary>Set stereo offset type</summary>
	public void SetStereoOffset(EDisplayClusterEyeStereoOffset InStereoOffset) {}
	///<summary>Gizmo visibility</summary>
	public bool bEnableGizmo;
	///<summary>Base gizmo scale</summary>
	public FVector BaseGizmoScale;
	///<summary>Gizmo scale multiplier</summary>
	public float GizmoScaleMultiplier;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>SpriteTexture</summary>
	public UTexture2D SpriteTexture;
	///<summary>InterpupillaryDistance</summary>
	public float InterpupillaryDistance;
	///<summary>bSwapEyes</summary>
	public bool bSwapEyes;
	///<summary>StereoOffset</summary>
	public EDisplayClusterEyeStereoOffset StereoOffset;
}
