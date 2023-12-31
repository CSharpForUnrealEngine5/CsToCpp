namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Context passed to any active root motion modifier during the update phase.</summary>
[CppInclude("RootMotionModifier.h")]
public partial struct FMotionWarpingUpdateContext {
	public TWeakObjectPtr<UAnimSequenceBase> Animation;
	public float PreviousPosition;
	public float CurrentPosition;
	public float Weight;
	public float PlayRate;
	public float DeltaSeconds;
}
