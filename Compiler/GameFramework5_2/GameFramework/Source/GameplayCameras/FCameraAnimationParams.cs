#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraAnimationCameraModifier.h")]
///<summary>Parameter struct for adding new camera animations to UCameraAnimationCameraModifier</summary>
public partial struct FCameraAnimationParams {
// CameraAnimationParams
	public float PlayRate;
	public float Scale;
	public ECameraAnimationEasingType EaseInType;
	public float EaseInDuration;
	public ECameraAnimationEasingType EaseOutType;
	public float EaseOutDuration;
	public bool bLoop;
	public bool bRandomStartTime;
	public float DurationOverride;
	public ECameraAnimationPlaySpace PlaySpace;
	public FRotator UserPlaySpaceRot;
}
