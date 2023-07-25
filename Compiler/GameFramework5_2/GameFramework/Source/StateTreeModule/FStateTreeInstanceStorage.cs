#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeInstanceData.h")]
///<summary>Storage for the actual instance data.</summary>
public partial struct FStateTreeInstanceStorage {
// StateTreeInstanceStorage
	public FInstancedStructContainer InstanceStructs;
	public TArray<UObject> InstanceObjects;
	public FStateTreeEventQueue EventQueue;
	public TArray<FStateTreeTransitionRequest> TransitionRequests;
}
