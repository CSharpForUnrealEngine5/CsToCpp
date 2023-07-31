#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameter struct for adding new camera animations to UCameraAnimationCameraModifier</summary>
[CppInclude("CameraAnimationCameraModifier.h")]
public partial struct FCameraAnimationParams {
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
