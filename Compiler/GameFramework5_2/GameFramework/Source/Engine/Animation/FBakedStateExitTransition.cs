#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FBakedStateExitTransition {
// BakedStateExitTransition
	public int CanTakeDelegateIndex;
	public int CustomResultNodeIndex;
	public int TransitionIndex;
	public bool bDesiredTransitionReturnValue;
	public bool bAutomaticRemainingTimeRule;
	public string SyncGroupNameToRequireValidMarkersRule;
	public TArray<int> PoseEvaluatorLinks;
}
