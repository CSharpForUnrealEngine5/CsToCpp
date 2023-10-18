namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationState/ReplicationStateDescriptorConfig.h")]
public partial class UReplicationStateDescriptorConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Structs that works using the default struct NetSerializer when running iris replication even though they implement a custom NetSerialize or NetDeltaSerialize method.</summary>
	public TArray<FSupportsStructNetSerializerConfig> SupportsStructNetSerializerList;
}
