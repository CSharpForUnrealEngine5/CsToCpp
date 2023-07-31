#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters for scrubbing a camera shake.</summary>
[CppInclude("Camera/CameraShakeBase.h")]
public partial struct FCameraShakeScrubParams {
	public float AbsoluteTime;
	public float ShakeScale;
	public float DynamicScale;
	public float BlendingWeight;
	public FMinimalViewInfo POV;
}
