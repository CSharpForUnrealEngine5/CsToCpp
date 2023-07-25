#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMPartition/ISMPartitionActor.h")]
///<summary>Actor base class for instance containers placed on a grid.</summary>
public partial class AISMPartitionActor : APartitionActor {
// ISMPartitionActor
	public TArray<FGuid> Clients;
	public TArray<FISMComponentDescriptor> Descriptors;
	public TArray<FISMComponentData> DescriptorComponents;
	public TMap<FGuid,FISMClientInstanceManagerData> ClientInstanceManagers;
}
