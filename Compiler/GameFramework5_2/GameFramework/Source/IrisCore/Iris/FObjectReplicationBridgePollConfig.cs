namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/ObjectReplicationBridgeConfig.h")]
public partial struct FObjectReplicationBridgePollConfig {
	public FName ClassName;
	public uint PollFramePeriod;
	public bool bIncludeSubclasses;
}
