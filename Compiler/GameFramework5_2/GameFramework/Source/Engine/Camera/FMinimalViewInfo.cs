namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraTypes.h")]
public partial struct FMinimalViewInfo {
	public FVector Location;
	public FRotator Rotation;
	public float FOV;
	public float DesiredFOV;
	public float OrthoWidth;
	public float OrthoNearClipPlane;
	public float OrthoFarClipPlane;
	public float PerspectiveNearClipPlane;
	public float AspectRatio;
	public bool bConstrainAspectRatio;
	public bool bUseFieldOfViewForLOD;
	public ECameraProjectionMode ProjectionMode;
	public float PostProcessBlendWeight;
	public FPostProcessSettings PostProcessSettings;
	public FVector2D OffCenterProjectionOffset;
}
