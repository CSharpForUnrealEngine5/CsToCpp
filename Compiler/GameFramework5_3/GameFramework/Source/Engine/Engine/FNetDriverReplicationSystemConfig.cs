namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to configure the replication system default values</summary>
[CppInclude("Engine/NetDriver.h")]
public partial struct FNetDriverReplicationSystemConfig {
	public uint MaxReplicatedObjectCount;
	public uint MaxDeltaCompressedObjectCount;
	public uint MaxNetObjectGroupCount;
}
