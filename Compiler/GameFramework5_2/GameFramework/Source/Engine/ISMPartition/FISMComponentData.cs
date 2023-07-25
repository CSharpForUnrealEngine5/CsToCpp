#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMPartition/ISMComponentData.h")]
///<summary>Bookkeeping struct that contains the data that allows linking Client Instances to actual Component Instances</summary>
public partial struct FISMComponentData {
// ISMComponentData
	public TArray<FISMComponentInstance> Instances;
	public TArray<FISMClientData> ClientInstances;
	public UInstancedStaticMeshComponent Component;
}
