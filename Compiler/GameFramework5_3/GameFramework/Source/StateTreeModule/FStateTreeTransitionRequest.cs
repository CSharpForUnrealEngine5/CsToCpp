namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transition request</summary>
[CppInclude("StateTreeExecutionTypes.h")]
public partial struct FStateTreeTransitionRequest {
	public FStateTreeStateHandle SourceState;
	public FStateTreeStateHandle TargetState;
	public EStateTreeTransitionPriority Priority;
}
