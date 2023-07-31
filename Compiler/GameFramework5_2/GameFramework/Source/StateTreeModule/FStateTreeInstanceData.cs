#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>StateTree instance data is used to store the runtime state of a StateTree.</summary>
[CppInclude("StateTreeInstanceData.h")]
public partial struct FStateTreeInstanceData {
	public FInstancedStruct InstanceStorage;
	public FInstancedStructContainer InstanceStructs_DEPRECATED;
	public TArray<UObject> InstanceObjects_DEPRECATED;
}
