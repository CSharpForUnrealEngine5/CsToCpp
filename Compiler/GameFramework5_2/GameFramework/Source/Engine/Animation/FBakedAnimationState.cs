#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FBakedAnimationState {
// BakedAnimationState
	public string StateName;
	public TArray<FBakedStateExitTransition> Transitions;
	public int StateRootNodeIndex;
	public int StartNotify;
	public int EndNotify;
	public int FullyBlendedNotify;
	public bool bIsAConduit;
	public int EntryRuleNodeIndex;
	public TArray<int> PlayerNodeIndices;
	public TArray<int> LayerNodeIndices;
	public bool bAlwaysResetOnEntry;
}
