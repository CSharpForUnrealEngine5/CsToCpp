#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeInstanceData.h")]
///<summary>StateTree instance data is used to store the runtime state of a StateTree.</summary>
public partial struct FStateTreeInstanceData {
// StateTreeInstanceData
	public FInstancedStruct InstanceStorage;
	public FInstancedStructContainer InstanceStructs_DEPRECATED;
	public TArray<UObject> InstanceObjects_DEPRECATED;
}
