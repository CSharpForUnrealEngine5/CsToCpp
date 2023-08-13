namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FBakedStateExitTransition {
	public int CanTakeDelegateIndex;
	public int CustomResultNodeIndex;
	public int TransitionIndex;
	public bool bDesiredTransitionReturnValue;
	public bool bAutomaticRemainingTimeRule;
	public string SyncGroupNameToRequireValidMarkersRule;
	public TArray<int> PoseEvaluatorLinks;
}
