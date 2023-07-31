#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimStateTransitionNode.h")]
public partial class UAnimStateTransitionNode : UAnimStateNodeBase {
	///<summary>The transition logic graph for this transition (returning a boolean)</summary>
	public UEdGraph BoundGraph;
	///<summary>The animation graph for this transition if it uses custom blending (returning a pose)</summary>
	public UEdGraph CustomTransitionGraph;
	///<summary>The priority order of this transition. If multiple transitions out of a state go</summary>
	public int PriorityOrder;
	///<summary>The duration to cross-fade for</summary>
	public float CrossfadeDuration;
	///<summary>The type of blending to use in the crossfade</summary>
	public ETransitionBlendMode CrossfadeMode_DEPRECATED;
	///<summary>BlendMode</summary>
	public EAlphaBlendOption BlendMode;
	///<summary>CustomBlendCurve</summary>
	public UCurveFloat CustomBlendCurve;
	///<summary>The blend profile to use to evaluate this transition per-bone</summary>
	public UBlendProfile BlendProfile;
	///<summary>Try setting the rule automatically based on most relevant player node&#39;s remaining time and the CrossfadeDuration of the transition, ignoring the internal time</summary>
	public bool bAutomaticRuleBasedOnSequencePlayerInState;
	///<summary>If SyncGroupName is specified, Transition will only be taken if the SyncGroup has valid markers (other transition rules still apply in addition to that).</summary>
	public string SyncGroupNameToRequireValidMarkersRule;
	///<summary>What transition logic to use</summary>
	public ETransitionLogicType LogicType;
	///<summary>TransitionStart</summary>
	public FAnimNotifyEvent TransitionStart;
	///<summary>TransitionEnd</summary>
	public FAnimNotifyEvent TransitionEnd;
	///<summary>TransitionInterrupt</summary>
	public FAnimNotifyEvent TransitionInterrupt;
	///<summary>This transition can go both directions</summary>
	public bool Bidirectional;
	///<summary>The rules for this transition may be shared with other transition nodes</summary>
	public bool bSharedRules;
	///<summary>The cross-fade settings of this node may be shared</summary>
	public bool bSharedCrossfade;
	///<summary>What we call this transition if we are shared (&#39;Transition X to Y&#39; can&#39;t be used since its used in multiple places)</summary>
	public string SharedRulesName;
	///<summary>Shared rules guid useful when copying between different state machines</summary>
	public FGuid SharedRulesGuid;
	///<summary>Color we draw in the editor as if we are shared</summary>
	public FLinearColor SharedColor;
	///<summary>SharedCrossfadeName</summary>
	public string SharedCrossfadeName;
	///<summary>SharedCrossfadeGuid</summary>
	public FGuid SharedCrossfadeGuid;
	///<summary>SharedCrossfadeIdx</summary>
	public int SharedCrossfadeIdx;
}
