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
