#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerSettings.h")]
public partial struct FNiagaraBakerCameraSettings {
	public ENiagaraBakerViewMode ViewMode;
	public FVector ViewportLocation;
	public FRotator ViewportRotation;
	public float OrbitDistance;
	public float FOV;
	public float OrthoWidth;
	public bool bUseAspectRatio;
	public float AspectRatio;
}
