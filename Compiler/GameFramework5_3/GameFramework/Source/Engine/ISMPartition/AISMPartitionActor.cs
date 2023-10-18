namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor base class for instance containers placed on a grid.</summary>
[CppInclude("ISMPartition/ISMPartitionActor.h")]
public partial class AISMPartitionActor : APartitionActor {
	public static UClass StaticClass() {return default;}
	///<summary>Clients</summary>
	public TArray<FGuid> Clients;
	///<summary>Descriptors</summary>
	public TArray<FISMComponentDescriptor> Descriptors;
	///<summary>DescriptorComponents</summary>
	public TArray<FISMComponentData> DescriptorComponents;
	///<summary>ClientInstanceManagers</summary>
	public TMap<FGuid,FISMClientInstanceManagerData> ClientInstanceManagers;
}
