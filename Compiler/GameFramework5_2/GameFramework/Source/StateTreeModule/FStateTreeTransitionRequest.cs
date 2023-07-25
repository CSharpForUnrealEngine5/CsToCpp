#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Transition request</summary>
public partial struct FStateTreeTransitionRequest {
// StateTreeTransitionRequest
	public FStateTreeStateHandle SourceState;
	public FStateTreeStateHandle TargetState;
	public EStateTreeTransitionPriority Priority;
}
