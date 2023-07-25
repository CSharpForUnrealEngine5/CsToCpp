#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier.h")]
///<summary>Context passed to any active root motion modifier during the update phase.</summary>
public partial struct FMotionWarpingUpdateContext {
// MotionWarpingUpdateContext
	public TWeakObjectPtr<UAnimSequenceBase> Animation;
	public float PreviousPosition;
	public float CurrentPosition;
	public float Weight;
	public float PlayRate;
	public float DeltaSeconds;
}
