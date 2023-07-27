#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DisplayClusterCameraComponent.h")]
///<summary>3D point in space used to render nDisplay viewports from</summary>
public partial class UDisplayClusterCameraComponent : USceneComponent {
// DisplayClusterCameraComponent
	public  float GetInterpupillaryDistance() { return default; }
	public  void SetInterpupillaryDistance(float Distance) {}
	public  bool GetSwapEyes() { return default; }
	public  void SetSwapEyes(bool SwapEyes) {}
	public  bool ToggleSwapEyes() { return default; }
	public  EDisplayClusterEyeStereoOffset GetStereoOffset() { return default; }
	public  void SetStereoOffset(EDisplayClusterEyeStereoOffset InStereoOffset) {}
	public bool bEnableGizmo;
	public FVector BaseGizmoScale;
	public float GizmoScaleMultiplier;
	public UBillboardComponent SpriteComponent;
	public UTexture2D SpriteTexture;
	public float InterpupillaryDistance;
	public bool bSwapEyes;
	public EDisplayClusterEyeStereoOffset StereoOffset;
}
