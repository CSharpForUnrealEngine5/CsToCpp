#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNotifyState_MotionWarping.h")]
///<summary>AnimNotifyState used to define a motion warping window in the animation</summary>
public partial class UAnimNotifyState_MotionWarping : UAnimNotifyState {
// AnimNotifyState_MotionWarping
	public URootMotionModifier RootMotionModifier;
	public  URootMotionModifier AddRootMotionModifier(UMotionWarpingComponent MotionWarpingComp,UAnimSequenceBase Animation,float StartTime,float EndTime) { return default; }
	public  void OnRootMotionModifierActivate(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	public  void OnRootMotionModifierUpdate(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	public  void OnRootMotionModifierDeactivate(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	public  void OnWarpBegin(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	public  void OnWarpUpdate(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	public  void OnWarpEnd(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
}
