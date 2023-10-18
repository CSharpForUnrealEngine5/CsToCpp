namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about an active camera animation inside UCameraAnimationCameraModifier.</summary>
[CppInclude("CameraAnimationCameraModifier.h")]
public partial struct FActiveCameraAnimationInfo {
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
