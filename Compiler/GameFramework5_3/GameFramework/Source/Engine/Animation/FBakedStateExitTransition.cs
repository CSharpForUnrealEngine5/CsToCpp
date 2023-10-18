namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FBakedStateExitTransition {
	public int CanTakeDelegateIndex;
	public int CustomResultNodeIndex;
	public int TransitionIndex;
	public bool bDesiredTransitionReturnValue;
	public bool bAutomaticRemainingTimeRule;
	public float AutomaticRuleTriggerTime;
	public FName SyncGroupNameToRequireValidMarkersRule;
	public TArray<int> PoseEvaluatorLinks;
}
