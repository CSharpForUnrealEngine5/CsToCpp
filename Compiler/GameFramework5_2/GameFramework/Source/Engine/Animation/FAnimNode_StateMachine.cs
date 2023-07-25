#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_StateMachine.h")]
///<summary>State machine node</summary>
public partial struct FAnimNode_StateMachine {
// AnimNode_StateMachine
	public int StateMachineIndexInClass;
	public int MaxTransitionsPerFrame;
	public int MaxTransitionsRequests;
	public bool bSkipFirstUpdateTransition;
	public bool bReinitializeOnBecomingRelevant;
	public bool bCreateNotifyMetaData;
	public bool bAllowConduitEntryStates;
}
