#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>URootMotionModifier</summary>
[CppInclude("RootMotionModifier.h")]
public partial class URootMotionModifier : UObject {
	///<summary>Source of the root motion we are warping</summary>
	public TWeakObjectPtr<UAnimSequenceBase> Animation;
	///<summary>Start time of the warping window</summary>
	public float StartTime;
	///<summary>End time of the warping window</summary>
	public float EndTime;
	///<summary>Previous playback time of the animation</summary>
	public float PreviousPosition;
	///<summary>Current playback time of the animation</summary>
	public float CurrentPosition;
	///<summary>Current blend weight of the animation</summary>
	public float Weight;
	///<summary>Character owner transform at the time this modifier becomes active</summary>
	public FTransform StartTransform;
	///<summary>Actual playback time when the modifier becomes active</summary>
	public float ActualStartTime;
	///<summary>Delegate called when this modifier is activated (starts affecting the root motion)</summary>
	public FOnRootMotionModifierDelegate OnActivateDelegate;
	///<summary>Delegate called when this modifier updates while active (affecting the root motion)</summary>
	public FOnRootMotionModifierDelegate OnUpdateDelegate;
	///<summary>Delegate called when this modifier is deactivated (stops affecting the root motion)</summary>
	public FOnRootMotionModifierDelegate OnDeactivateDelegate;
	///<summary>Current state</summary>
	public ERootMotionModifierState State;
}
