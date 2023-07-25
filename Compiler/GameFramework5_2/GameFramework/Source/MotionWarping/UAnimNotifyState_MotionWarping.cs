#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNotifyState_MotionWarping.h")]
///<summary>AnimNotifyState used to define a motion warping window in the animation</summary>
public partial class UAnimNotifyState_MotionWarping : UAnimNotifyState {
// AnimNotifyState_MotionWarping
	public URootMotionModifier RootMotionModifier;
	public UObject AddRootMotionModifier(UObject MotionWarpingComp,UObject Animation,float StartTime,float EndTime) { return default; }
	public void OnRootMotionModifierActivate(UObject MotionWarpingComp,UObject Modifier) {}
	public void OnRootMotionModifierUpdate(UObject MotionWarpingComp,UObject Modifier) {}
	public void OnRootMotionModifierDeactivate(UObject MotionWarpingComp,UObject Modifier) {}
	public void OnWarpBegin(UObject MotionWarpingComp,UObject Modifier) {}
	public void OnWarpUpdate(UObject MotionWarpingComp,UObject Modifier) {}
	public void OnWarpEnd(UObject MotionWarpingComp,UObject Modifier) {}
}
