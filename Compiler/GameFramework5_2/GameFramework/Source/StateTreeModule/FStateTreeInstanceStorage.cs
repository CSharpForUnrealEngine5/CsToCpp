#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Storage for the actual instance data.</summary>
[CppInclude("StateTreeInstanceData.h")]
public partial struct FStateTreeInstanceStorage {
	public FInstancedStructContainer InstanceStructs;
	public TArray<UObject> InstanceObjects;
	public FStateTreeEventQueue EventQueue;
	public TArray<FStateTreeTransitionRequest> TransitionRequests;
}
