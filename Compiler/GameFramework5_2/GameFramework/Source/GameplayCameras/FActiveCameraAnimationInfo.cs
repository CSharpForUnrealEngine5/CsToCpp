#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraAnimationCameraModifier.h")]
///<summary>Information about an active camera animation inside UCameraAnimationCameraModifier.</summary>
public partial struct FActiveCameraAnimationInfo {
// ActiveCameraAnimationInfo
	public UCameraAnimationSequence Sequence;
	public FCameraAnimationParams Params;
	public FCameraAnimationHandle Handle;
	public UCameraAnimationSequencePlayer Player;
	public UCameraAnimationSequenceCameraStandIn CameraStandIn;
	public float EaseInCurrentTime;
	public float EaseOutCurrentTime;
	public bool bIsEasingIn;
	public bool bIsEasingOut;
}
