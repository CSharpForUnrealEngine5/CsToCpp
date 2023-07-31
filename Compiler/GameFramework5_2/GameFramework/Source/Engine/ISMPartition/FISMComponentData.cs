#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Bookkeeping struct that contains the data that allows linking Client Instances to actual Component Instances</summary>
[CppInclude("ISMPartition/ISMComponentData.h")]
public partial struct FISMComponentData {
	public TArray<FISMComponentInstance> Instances;
	public TArray<FISMClientData> ClientInstances;
	public UInstancedStaticMeshComponent Component;
}
