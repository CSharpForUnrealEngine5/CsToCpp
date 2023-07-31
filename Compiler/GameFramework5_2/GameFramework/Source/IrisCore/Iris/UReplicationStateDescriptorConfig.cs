#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationState/ReplicationStateDescriptorConfig.h")]
public partial class UReplicationStateDescriptorConfig : UObject {
	///<summary>Structs that works using the default struct NetSerializer when running iris replication even though they implement a custom NetSerialize or NetDeltaSerialize method.</summary>
	public TArray<FSupportsStructNetSerializerConfig> SupportsStructNetSerializerList;
}
