#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier.h")]
///<summary>URootMotionModifier</summary>
public partial class URootMotionModifier : UObject {
// RootMotionModifier
	public TWeakObjectPtr<UAnimSequenceBase> Animation;
	public float StartTime;
	public float EndTime;
	public float PreviousPosition;
	public float CurrentPosition;
	public float Weight;
	public FTransform StartTransform;
	public float ActualStartTime;
	public FOnRootMotionModifierDelegate OnActivateDelegate;
	public FOnRootMotionModifierDelegate OnUpdateDelegate;
	public FOnRootMotionModifierDelegate OnDeactivateDelegate;
	public ERootMotionModifierState State;
}
