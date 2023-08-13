namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AnimNotifyState used to define a motion warping window in the animation</summary>
[CppInclude("AnimNotifyState_MotionWarping.h")]
public partial class UAnimNotifyState_MotionWarping : UAnimNotifyState {
	public static UClass StaticClass() {return default;}
	///<summary>@TODO: Prevent notify callbacks and add comments explaining why we don&#39;t use those here.</summary>
	public URootMotionModifier RootMotionModifier;
	///<summary>Creates a root motion modifier from the config class defined in the notify</summary>
	public URootMotionModifier AddRootMotionModifier(UMotionWarpingComponent MotionWarpingComp,UAnimSequenceBase Animation,float StartTime,float EndTime) { return default; }
	///<summary>OnRootMotionModifierActivate</summary>
	public void OnRootMotionModifierActivate(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	///<summary>OnRootMotionModifierUpdate</summary>
	public void OnRootMotionModifierUpdate(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	///<summary>OnRootMotionModifierDeactivate</summary>
	public void OnRootMotionModifierDeactivate(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	///<summary>OnWarpBegin</summary>
	public void OnWarpBegin(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	///<summary>OnWarpUpdate</summary>
	public void OnWarpUpdate(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
	///<summary>OnWarpEnd</summary>
	public void OnWarpEnd(UMotionWarpingComponent MotionWarpingComp,URootMotionModifier Modifier) {}
}
