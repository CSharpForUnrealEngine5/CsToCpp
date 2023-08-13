namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>State machine node</summary>
[CppInclude("Animation/AnimNode_StateMachine.h")]
public partial struct FAnimNode_StateMachine {
	public int StateMachineIndexInClass;
	public int MaxTransitionsPerFrame;
	public int MaxTransitionsRequests;
	public bool bSkipFirstUpdateTransition;
	public bool bReinitializeOnBecomingRelevant;
	public bool bCreateNotifyMetaData;
	public bool bAllowConduitEntryStates;
}
